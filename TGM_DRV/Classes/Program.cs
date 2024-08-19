using LmCorbieUI;
using System;
using System.Windows.Forms;

namespace TGM_DRV {
  internal static class Program {
    /// <summary>
    /// Ponto de entrada principal para o aplicativo.
    /// </summary>
    [STAThread]
    static void Main() {
      string nomeSistem = "TGM Data Report Viewer";
      string pastaRaiz = "LM Projetos Data";
      string cliente = "TGM";
      string mail = "michalakleo@gmail.com";
      ValPadrao.DefinirPadrao(pastaRaiz, nomeSistem, cliente, mail);

      SemearBase.CriarTabelas();

      ValorPredefinido.Carregar();
      FTP.Carregar();
      DataUltimoArquivoLido.Carregar();
      ColumnInfo.Carregar();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmPrincipal());
    }
  }
}
