using CsvHelper.Configuration;
using CsvHelper;
using FluentFTP;
using LmCorbieUI;
using LmCorbieUI.LmForms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TGM_DRV {
  public partial class FrmImportar : LmSingleForm {
    public FrmImportar() {
      InitializeComponent();
    }

    private void btnImportar_Click(object sender, System.EventArgs e) {
      btnImportar.Enabled = false;
      lblInfo.Visible = true;
      System.Threading.Thread t = new System.Threading.Thread(() => { IniciarImportacao(); }) { IsBackground = true };
      t.Start();
    }

    private void IniciarImportacao() {
      string pastaRaiz = ValPadrao.PastaTemp;

      string ftpServer = FTP.model.ServerFTP;
      string username = FTP.model.UsuarioFTP;
      string password = FTP.model.SenhaFTP;
      string subFolder = FTP.model.DiretorioFTP;

      try {
        Invoke(new MethodInvoker(delegate () {
          if (ftpServer == null) {
            MsgBox.Show("Você deve configurar o acesso ao FTP primeiro.",
              "Ação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
          }

          lblInfo.Text = "Testando Conexão FTP";
          lblInfo.Refresh();

          var resultadoPing = MonitorProcess.StartProcess("ping " + ftpServer.Replace("ftp://", ""));
          resultadoPing = FormatarTexto(resultadoPing);

          if (PossuiConexao(resultadoPing)) {
            lblInfo.Text = "Analisando arquivos do FTP";
            lblInfo.Refresh();

            // Garantir que o ftpServer termina com "/"
            if (!ftpServer.EndsWith("/"))
              ftpServer += "/";

            // Garantir que o subFolder não começa com "/"
            if (subFolder.StartsWith("/"))
              subFolder = subFolder.Substring(1);

            string ftpHost = ftpServer + subFolder;

            using (FtpClient client = new FtpClient(ftpServer, username, password)) {
              client.Connect();

              // Verificar se a conexão foi estabelecida
              if (client.IsConnected) {
                Console.WriteLine("Conexão estabelecida com sucesso.");

                // Tente navegar diretamente para a subpasta
                try {
                  client.SetWorkingDirectory(subFolder);
                  Console.WriteLine($"Diretório atual: {client.GetWorkingDirectory()}");
                } catch (Exception ex) {
                  Console.WriteLine($"Erro ao navegar para a subpasta: {ex.Message}");
                  MsgBox.Show($"Erro ao navegar para a subpasta: {ex.Message}",
                      "Erro de Navegação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
                }

                if (client.GetWorkingDirectory().EndsWith(subFolder)) {
                  var dataUltimaLeitura = DataUltimoArquivoLido.model.Data;
                  var itens = client.GetListing()
                      .Where(item => item.Type == FtpObjectType.File && item.Modified > dataUltimaLeitura && Path.GetExtension(item.Name).ToUpper().EndsWith("CSV"))
                      .OrderBy(item => item.Modified)
                      .ToList();

                  if (itens.Count == 0) {
                    MsgBox.Show("Nenhum CSV encontrado para coletar os dados.",
                      "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  } else {
                    lblInfo.Text = "Lendo Dados FTP, Aguarde...";
                    lblInfo.Refresh();
                    foreach (var item in itens) {
                      string fileName = item.FullName;

                      DateTime lastModified = item.Modified;

                      string localPath = Path.Combine(pastaRaiz, Path.GetFileName(fileName));

                      client.DownloadFile(localPath, fileName);

                      LerCsv(localPath);

                      dataUltimaLeitura = lastModified;
                    }
                    DataUltimoArquivoLido.model.Data = dataUltimaLeitura;
                    DataUltimoArquivoLido.Salvar();
                  }
                } else {
                  MsgBox.Show($"Diretório '{subFolder}' não encontrado.\r\nCorrija na tela Configurar FTP.",
                    "Ação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
              } else {
                MsgBox.Show("Falha na conexão ao servidor FTP.\r\nVerifique os dados configurados a tela Configurar FTP.",
                  "Ação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("");
              }
            }
          } else {
            MsgBox.Show("Falha na conexão ao servidor FTP.\r\nVerifique os dados configurados a tela Configurar FTP.",
              "Ação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Console.WriteLine("");
          }
        }));
      } catch (FluentFTP.Exceptions.FtpAuthenticationException ex) {
        if (ex.Message.Contains("Permission denied")) {
          MsgBox.Show($"O usuário '{username}' não tem acesso a pasta do FTP.\r\nCorrija na tela Configurar FTP.",
            "Ação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } else if (ex.Message.Contains("Login incorrect")) {
          MsgBox.Show("Login ou senha do FTP estão incorretos.\r\nCorrija na tela Configurar FTP.",
            "Ação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } else {
          LmException.ShowException(ex, "Erro ao Ler dados do FTP");
        }
      } catch (Exception ex) {
        if (ex.Message.Contains("Timed out trying to connect")) {
          MsgBox.Show($"Não foi possível conectar-se ao Servidor FTP.\r\nVerifique as configurações da tela Configurar FTP.",
            "Ação não Permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        } else
          LmException.ShowException(ex, "Erro ao Importar");
      } finally {
        Invoke(new MethodInvoker(delegate () {
          btnImportar.Enabled = true;
          lblInfo.Visible = false;
        }));
      }
    }

    private void LerCsv(string filePath) {
      // Detectar o delimitador
      var delimitador = DetectarDelimitador(filePath);

      var config = new CsvConfiguration(CultureInfo.InvariantCulture) {
        Delimiter = delimitador,
        HasHeaderRecord = true,
      };

      using (var reader = new StreamReader(filePath, System.Text.Encoding.GetEncoding("ISO-8859-9")))
      using (var csv = new CsvReader(reader, config)) {
        // Leitura dos headers
        csv.Read();
        csv.ReadHeader();
        var headerRow = csv.HeaderRecord;

        // Criar um dicionário para armazenar os dados dinamicamente
        var data = new List<Dictionary<string, string>>();

        // Ler as linhas de dados
        while (csv.Read()) {
          var row = new Dictionary<string, string>();
          foreach (var header in headerRow) {
            row[header] = csv.GetField(header);
          }
          data.Add(row);
        }

        using (SQLiteContexto db = new SQLiteContexto())
        using (var transaction = db.Database.BeginTransaction()) {
          try {
            var nameCSV = Path.GetFileName(filePath).ToUpper();
            var regLido = db.RegistroLido.FirstOrDefault(x => x.NomeArquivo == nameCSV);
            if (regLido == null)
              regLido = new RegistroLido { NomeArquivo = nameCSV, UltimaLinhalida = 0, };

            for (int i = regLido.UltimaLinhalida; i < data.Count; i++) {
              Dictionary<string, string> row = data[i];
              Registro registro = new Registro();
              foreach (var col in ColumnInfo.model.Columns) {
                var name = col.Name.Trim();
                var display = col.Display.Trim();
                if (string.IsNullOrEmpty(display))
                  continue;

                var kvp = row.FirstOrDefault(x => x.Key.Trim() == display);
                if (!kvp.Equals(default(KeyValuePair<string, string>))) {
                  var valor = kvp.Value;

                  switch (name) {
                    case "Data":
                    registro.Data = Convert.ToDateTime(valor);
                    break;
                    case "Coluna1":
                    registro.Coluna1 = valor;
                    break;
                    case "Coluna2":
                    registro.Coluna2 = valor;
                    break;
                    case "Coluna3":
                    registro.Coluna3 = valor;
                    break;
                    case "Coluna4":
                    registro.Coluna4 = valor;
                    break;
                    case "Coluna5":
                    registro.Coluna5 = valor;
                    break;
                    case "Coluna6":
                    registro.Coluna6 = valor;
                    break;
                    case "Coluna7":
                    registro.Coluna7 = valor;
                    break;
                    case "Coluna8":
                    registro.Coluna8 = valor;
                    break;
                    case "Coluna9":
                    registro.Coluna9 = valor;
                    break;
                    case "Coluna10":
                    registro.Coluna10 = valor;
                    break;
                    case "Coluna11":
                    registro.Coluna11 = valor;
                    break;
                    case "Coluna12":
                    registro.Coluna12 = valor;
                    break;
                    case "Coluna13":
                    registro.Coluna13 = valor;
                    break;
                    case "Coluna14":
                    registro.Coluna14 = valor;
                    break;
                    case "Coluna15":
                    registro.Coluna15 = valor;
                    break;
                    case "Coluna16":
                    registro.Coluna16 = valor;
                    break;
                    case "Coluna17":
                    registro.Coluna17 = valor;
                    break;
                    case "Coluna18":
                    registro.Coluna18 = valor;
                    break;
                    case "Coluna19":
                    registro.Coluna19 = valor;
                    break;
                    default:
                    break;
                  }
                }
              }
              regLido.UltimaLinhalida = i + 1;

              db.Registro.Add(registro);
            }

            if (regLido.Id == 0)
              db.RegistroLido.Add(regLido);

            db.SaveChanges();
            transaction.Commit();
          } catch (Exception ex) {
            transaction.Rollback();
            throw ex;
          }
        }
      }
    }

    private string DetectarDelimitador(string filePath) {
      using (var reader = new StreamReader(filePath)) {
        var firstLine = reader.ReadLine();
        var countComma = firstLine.Count(c => c == ',');
        var countSemicolon = firstLine.Count(c => c == ';');

        return countComma > countSemicolon ? "," : ";";
      }
    }

    private static string FormatarTexto(string txt) {
      return txt
          .Replace("% de\r\n             perda)", "% de perda)")
          .Replace("Verifique o nome e tente\r\nnovamente.", "Verifique o nome e tente novamente.")
          .Replace("M ximo", "Máximo")
          .Replace("M‚dia", "Média")
          .Replace("“", "ô")
          .Replace("Æ", "ã")
          .Replace("¢", "ó")
          .Replace("¡", "í")
          .Replace("‡", "ç");
    }

    private static bool PossuiConexao(string resultado) {
      if (
          resultado.ToLower().Contains("a solicitação ping não pôde encontrar o host") ||
          resultado.ToLower().Contains("verifique o nome e tente novamente") ||
          resultado.ToLower().Contains("100% de perda"))
        return false;
      else
        return true;

    }

  }
}
