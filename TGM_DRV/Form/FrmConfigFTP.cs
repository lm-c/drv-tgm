using LmCorbieUI.Controls;
using LmCorbieUI.LmForms;
using LmCorbieUI.Metodos;
using System.Windows.Forms;

namespace TGM_DRV {
  public partial class FrmConfigFTP : LmChildForm {
    public FrmConfigFTP() {
      InitializeComponent();
    }

    private void FrmConfigFTP_Loaded(object sender, System.EventArgs e) {
      Invoke(new MethodInvoker(delegate () {
        txtServer.Text = FTP.model.ServerFTP;
        txtUsuario.Text = FTP.model.UsuarioFTP;
        txtSenha.Text = FTP.model.SenhaFTP;
        txtDiretorio.Text = FTP.model.DiretorioFTP;

        btnSalvar.Enabled = true;
      }));
    }

    private void BtnSalvar_Click(object sender, System.EventArgs e) {
      if (Controles.PossuiCamposInvalidos(this)) return;

      using (SQLiteContexto db = new SQLiteContexto()) {
        FTP.model.ServerFTP = txtServer.Text;
        FTP.model.UsuarioFTP = txtUsuario.Text;
        FTP.model.SenhaFTP = txtSenha.Text;
        FTP.model.DiretorioFTP = txtDiretorio.Text;

        FTP.Salvar();
      }
    }

    private void TxtSenha_ButtonClickF7(object sender, System.EventArgs e) {
      if (((LmTextBox)sender).UseSystemPasswordChar) {
        ((LmTextBox)sender).UseSystemPasswordChar = false;
        ((LmTextBox)sender).PasswordChar = '\0';
        ((LmTextBox)sender).IconF7 = Properties.Resources.olho_fechado;
        ((LmTextBox)sender).F7ToolTipText = "Ocultar Senha";
      } else {
        ((LmTextBox)sender).UseSystemPasswordChar = true;
        ((LmTextBox)sender).IconF7 = Properties.Resources.olho_aberto;
        ((LmTextBox)sender).F7ToolTipText = "Exibir Senha";
      }

        ((LmTextBox)sender).Refresh();
    }
  }
}
