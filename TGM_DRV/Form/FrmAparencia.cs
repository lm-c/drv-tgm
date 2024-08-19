using System;
using System.Drawing;
using System.Windows.Forms;
using LmCorbieUI;
using LmCorbieUI.Design;
using LmCorbieUI.LmForms;

namespace TGM_DRV {
  public partial class FrmAparencia : LmChildForm {
    Image imagemFundo = null;

    public FrmAparencia() {
      InitializeComponent();

      Modo = Modo.Padrao;
    }

    private void FrmAparencia_Load(object sender, EventArgs e) {
    }

    private void FrmAparencia_Loaded(object sender, EventArgs e) {
      Invoke(new MethodInvoker(delegate () {

      }));
    }

    private void Pnl_Click(object sender, EventArgs e) {
      MsgBox.ShowWaitMessage("Aplicando Tema. Aguarde...");
      LmCor.CorPrimaria = ((Control)sender).BackColor;
      LmCor.CorSecundaria = ((Control)sender).Tag.ToString().StringToColor();

      ValorPredefinido.model.CorPrimaria = LmCor.CorPrimaria.ColorToString();
      ValorPredefinido.model.CorSecundaria = LmCor.CorSecundaria.ColorToString();

      FrmPrincipal.Instancia.Refresh();
      FrmPrincipal.Instancia.Invalidate();

      FrmPrincipal.Instancia.AttControls(FrmPrincipal.Instancia);

      ValorPredefinido.Salvar();

      MsgBox.Show("Tema aplicado com sucesso.\r\nFeche as telas abertas e abra novamente, caso algum componete não tenha aderido as novas cores.",
        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

      //Thread t = new Thread(() => { Style.SetOrUpdate(); }) { IsBackground = true };
      //t.Start();
    }

    private void BtnSelecionarCor_Click(object sender, EventArgs e) {
      try {
        ColorDialog cld = new ColorDialog {
          FullOpen = true,
          Color = ValorPredefinido.model.CorPrimaria.StringToColor(),
        };

        if (cld.ShowDialog() == DialogResult.OK) {
          MsgBox.ShowWaitMessage("Aplicando Tema, Aguarde...");
          LmCor.CorPrimaria = cld.Color;
          ValorPredefinido.model.CorPrimaria = cld.Color.ColorToString();

          FrmPrincipal.Instancia.Refresh();
          FrmPrincipal.Instancia.Invalidate();

          FrmPrincipal.Instancia.AttControls(FrmPrincipal.Instancia);

          ValorPredefinido.Salvar();

          MsgBox.Show("Tema aplicado com sucesso.\r\nFeche as telas abertas e abra novamente, caso algum componete não tenha aderido as novas cores.",
            "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao selecionar Cor");
      } finally { MsgBox.CloseWaitMessage(); }
    }

    private void FrmAparencia_FormClosing(object sender, FormClosingEventArgs e) {

    }
  }
}
