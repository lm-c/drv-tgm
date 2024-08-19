using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Linq;
using System.Windows.Forms;
using LmCorbieUI;

namespace TGM_DRV {
  internal class FTP {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [DataObjectField(true, false)]
    public int Id { get; set; }

    [StringLength(80)]
    public string ServerFTP { get; set; }
    
    [StringLength(80)]
    public string UsuarioFTP { get; set; }

    [StringLength(80)]
    public string SenhaFTP { get; set; }
    
    [StringLength(250)]
    public string DiretorioFTP { get; set; }

    public static FTP model = new FTP();

    public static void Salvar() {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          var valPredef = db.FTP.FirstOrDefault();

          if (valPredef == null) {
            model.Id = 1;
            db.FTP.Add(model);
          } else {
            valPredef.Id = model.Id;
            valPredef.ServerFTP = model.ServerFTP;
            valPredef.UsuarioFTP = model.UsuarioFTP;
            valPredef.SenhaFTP = model.SenhaFTP;
            valPredef.DiretorioFTP = model.DiretorioFTP;
          }

          db.SaveChanges();

          MsgBox.Show("Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      } catch (Exception ex) {
        MsgBox.Show("Aconteceu um Erro ao Salvar Configurações FTP, algumas predefinições de usuário podem não ter sidas salvas.\n" +
            "-------------------------------------\n" +
            "" + ex.Message,
            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static void Carregar() {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          model = db.FTP.FirstOrDefault();

          if (model == null)
            model = new FTP();          
        }
      } catch (Exception ex) {
        MsgBox.Show("Aconteceu um Erro ao Retornar Configurações FTP, algumas predefinições de usuário podem não ter sidas carregadas.\n" +
            "-------------------------------------\n" +
            "" + ex.Message,
            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    /// <summary>
    /// Upload de arquivos
    /// </summary>
    /// <param name="arquivo">Path do Arquivo a ser enviado</param>
    /// <param name="uri">URL acesso ao Servidor Ex: "ftp://192.168.20.777/nomeArquivo.extensao"</param>
    /// <param name="usuario">Usuário FTP</param>
    /// <param name="senha">Senha de Acesso ao Servidor FTP</param>
    internal static bool EnviarArquivoFTP(string arquivo, string uri, string usuario, string senha) {
      try {
        var request = (FtpWebRequest)WebRequest.Create(uri);
        request.Method = WebRequestMethods.Ftp.UploadFile;
        request.Credentials = new NetworkCredential(usuario, senha);

        var conteudoArquivo = File.ReadAllBytes(arquivo);
        request.ContentLength = conteudoArquivo.Length;

        var requestStream = request.GetRequestStream();
        requestStream.Write(conteudoArquivo, 0, conteudoArquivo.Length);
        requestStream.Close();

        var response = (FtpWebResponse)request.GetResponse();
        Debug.Print("Upload completo. Status: {0}", response.StatusDescription);
        response.Close();

        return true;
      } catch (Exception ex) {
        return false;
        throw ex;
      }
    }

    /// <summary>
    /// Download de arquivos
    /// </summary>
    /// <param name="uri">URL acesso ao Servidor Ex: "ftp://192.168.20.777/nomeArquivo.extensao"</param>
    /// <param name="destino">Diretório local para baixar Arquivo</param>
    /// <param name="usuario">Usuário FTP</param>
    /// <param name="senha">Senha de Acesso ao Servidor FTP</param>
    internal static bool BaixarArquivoFTP(string uri, string destino, string usuario, string senha/*, out string responseMessage*/) {
      try {
        var request = (FtpWebRequest)WebRequest.Create(uri);
        request.Method = WebRequestMethods.Ftp.DownloadFile;
        request.Credentials = new NetworkCredential(usuario, senha);

        var response = (FtpWebResponse)request.GetResponse();

        var responseStream = response.GetResponseStream();
        using (var memoryStream = new MemoryStream()) {
          responseStream.CopyTo(memoryStream);
          var conteudoArquivo = memoryStream.ToArray();
          File.WriteAllBytes(destino, conteudoArquivo);
        }

        Debug.Print("Download Complete, status {0}", response.StatusDescription);
        response.Close();
        // responseMessage = string.Empty;
        return true;
      } catch (Exception ex) {
        //  responseMessage = ex.Message;
        // CmxMessageBox.MsgBox.ShowHide(null, $"{ex.Message}\n\nArquivo: {uri}","Erro FTP",System.Windows.Forms.MessageBoxIcon.Error,true);
        return false;
      }
    }

  }
}
