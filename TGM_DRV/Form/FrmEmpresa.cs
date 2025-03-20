using LmCorbieUI;
using LmCorbieUI.Controls;
using LmCorbieUI.LmForms;
using LmCorbieUI.Metodos;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TGM_DRV {
  public partial class FrmEmpresa : LmChildForm {
    public FrmEmpresa() {
      InitializeComponent();
    }

    private void FrmEmpresa_Loaded(object sender, System.EventArgs e) {
      Invoke(new MethodInvoker(delegate () {
        txtRazaoSocial.Text = Empresa.model.RazaoSocial;
        txtCep.Text = Empresa.model.Cep;
        txtEndereco.Text = Empresa.model.Endereco;
        txtNumeroEndereco.Text = Empresa.model.EnderecoNumero;
        txtBairro.Text = Empresa.model.Bairro;
        txtCidade.Text = Empresa.model.Cidade;
        txtEstado.Text = Empresa.model.Estado;
        txtFone.Text = Empresa.model.Fone;
        ptbImagem.BackgroundImage = Empresa.model.LogoEmpresa.ToImageFromBase64();

        btnSalvar.Enabled = btnLogo.Enabled = true;
      }));
    }

    private void BtnSalvar_Click(object sender, System.EventArgs e) {
      if (Controles.PossuiCamposInvalidos(this)) return;

      using (SQLiteContexto db = new SQLiteContexto()) {
        Empresa.model.RazaoSocial = txtRazaoSocial.Text;
        Empresa.model.Cep = txtCep.Text;
        Empresa.model.Endereco = txtEndereco.Text;
        Empresa.model.EnderecoNumero = txtNumeroEndereco.Text;
        Empresa.model.Bairro = txtBairro.Text;
        Empresa.model.Cidade = txtCidade.Text;
        Empresa.model.Estado = txtEstado.Text;
        Empresa.model.Fone = txtFone.Text;
        Empresa.model.LogoEmpresa = ptbImagem.BackgroundImage.ToBase64String();

        Empresa.Salvar();
      }
    }

    private void BtnLogo_Click(object sender, System.EventArgs e) {
      OpenFileDialog ofd1 = new OpenFileDialog {
        Title = "Selecionar a imagem (JPG ou PNG).",
        Filter = "Imagem (JPEG - PNG)|*.JPG;*.JPEG;*.PNG",
        CheckFileExists = true,
        CheckPathExists = true,
        FilterIndex = 1,
        RestoreDirectory = true
      };

      if (ofd1.ShowDialog() == DialogResult.OK) {
        string extansao = Path.GetExtension(ofd1.FileName.ToUpper());
        if (extansao == ".JPG" || extansao == ".JPEG" || extansao == ".PNG") {
          //if (extansao == ".PNG")
          //  MsgBox.Show("Este tipo de imagem (PNG) pode perder a qualidade ao gerar relatório", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);

          Image image = Image.FromFile(ofd1.FileName);

          string img64 = image.ToBase64String();

          if (img64.Length > 4000000) {
            while (true) {
              image = image.SetImageQuality(50);
              img64 = image.ToBase64String();
              if (img64.Length < 3000000)
                break;
            }
          }

          GC.SuppressFinalize(img64);
          GC.Collect();

          ptbImagem.BackgroundImage = image;
        } else {
          MsgBox.Show("Selecione apenas Arquivos de imagem", "Arquivo Invalido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }
  }
}
