using LmCorbieUI;
using LmCorbieUI.Controls;
using LmCorbieUI.Design;
using LmCorbieUI.LmForms;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TGM_DRV {
  public partial class FrmPrincipal : LmMainForm {
    static readonly DateTime dt = DateTime.Now;
    internal string SecaoAtual =
         dt.Year +
         dt.Month.ToString("00") +
         dt.Day.ToString("00") +
         dt.Hour.ToString("00") +
         dt.Minute.ToString("00") +
         dt.Second.ToString("00") +
         dt.Millisecond.ToString("000");

    string versaoAtual = "0";

    static FrmPrincipal instancia;
    internal static FrmPrincipal Instancia {
      get {
        if (instancia == null)
          instancia = new FrmPrincipal();
        return instancia;
      }
    }

    public FrmPrincipal() {
      InitializeComponent();

      SetarAparencia();

      instancia = this;

      WindowState = FormWindowState.Maximized;

      tslSecao.Text = $"Seção: {SecaoAtual}";

      versaoAtual = Assembly.GetExecutingAssembly().GetName().Version.ToString();
      tslVersao.Text = $"Versão: {versaoAtual}";

      if (!ValPadrao.NomeSistema.Contains("Versão"))
        ValPadrao.NomeSistema += " " + tslVersao.Text;

      Text = $"TGM Data Report Viewer";

      tslModo.Text = string.Empty;
      tslFormAberto.Text = string.Empty;

      string dadosEmpresa = "";
      dadosEmpresa += $"\nCEP 89278-000 - Rua Progresso, 221";
      dadosEmpresa += $"\nDistrito Industrial - Corupá - SC";
      dadosEmpresa += $"\nFone (47) 3375-2177";

      InfoDefaultUI.UsuarioLogado_Login = "Cliente";
      InfoDefaultUI.DadosEmpresa = dadosEmpresa;
      InfoDefaultUI.LogoEmpresa = Properties.Resources.LOGO_TGM_ICONE;
    }

    private void FrmPrincipal_Load(object sender, EventArgs e) {
      PosicionarMenu(false);

      System.Threading.Thread t1 = new System.Threading.Thread(() => { SetarBackGroundImage(); }) { IsBackground = true };
      t1.Start();

      System.Threading.Thread t2 = new System.Threading.Thread(() => { ConfigurarRodape(); }) { IsBackground = true };
      t2.Start();
    }

    private void FrmPrincipal_Loaded(object sender, EventArgs e) {

    }

    private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
      try {
        foreach (var file in (Directory.GetFiles(ValPadrao.PastaTemp)))
          File.Delete(file);

        foreach (var dir in (Directory.GetDirectories(ValPadrao.PastaTemp)))
          Directory.Delete(dir, true);
      } catch (Exception) {
      }
    }

    private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }

    private void TmrMemory_Tick(object sender, EventArgs e) {
      tmrMemory.Enabled = false;

      System.Threading.Thread t = new System.Threading.Thread(() => { VerMemoria(); }) { IsBackground = true };
      t.Start();
    }

    #region Metodos

    internal void PosicionarMenu(bool salvarPropriedades = true) {
      var sizeX = ValorPredefinido.model.MostrarApenasIconeMenu ? 45 : 190;
      var sizeY = ValorPredefinido.model.MostrarIconePequeno ? 35 : 45;

      pnlMenu.SendToBack();
      pnlMenu.Width = sizeX;

      menuSandwich.Height = sizeY;

      if (ValorPredefinido.model.MostrarApenasIconeMenu) {
        pnlLogo.Height = sizeY;
        ptbLogo.Visible = false;
      } else {
        pnlLogo.Height = 60;
        ptbLogo.Visible = true;
      }
      ptbLogo.Visible = !ValorPredefinido.model.MostrarApenasIconeMenu;

      foreach (var menuItem in pnlMenu.Controls.OfType<LmMenuItem>()) {
        menuItem.Size = new Size(sizeX, sizeY);

        var text = !string.IsNullOrEmpty(menuItem.Text) ? menuItem.Text.Trim() : toolTip1.GetToolTip(menuItem).Trim();

        menuItem.Text = ValorPredefinido.model.MostrarApenasIconeMenu ? "" : "   " + text;
        toolTip1.SetToolTip(menuItem, ValorPredefinido.model.MostrarApenasIconeMenu ? text : "");

        menuItem.ImageAlign =
        ValorPredefinido.model.MostrarApenasIconeMenu || string.IsNullOrEmpty(text)
        ? ContentAlignment.MiddleCenter
        : ContentAlignment.MiddleLeft;
      }

      LmCor.CorPrimaria = ValorPredefinido.model.CorPrimaria.StringToColor();
      LmCor.CorSecundaria = ValorPredefinido.model.CorSecundaria.StringToColor();

      AttControls(FrmPrincipal.Instancia);

      this.pnlMain.BackgroundImage = Properties.Resources.LOGO_TGM_FUNDO;

      //AttControls(FrmPrincipal.Instancia);
    }

    internal void AttControls(Control control) {
      foreach (var item in control.Controls) {
        if (item is LmMenuItem menuItem) {
          menuItem.AplicarStilo();
          menuItem.Refresh();
        }

        if (item is LmButton btn) {
          btn.AplicarStilo();
          btn.Refresh();
        }

        if (control.Controls.Count > 0)
          AttControls((Control)item);

        this.tslVersao.ForeColor =
        this.tslSecao.ForeColor =
        this.tslConsumoMemoria.ForeColor =
        this.tslFormAberto.ForeColor = this.menuSandwich.ForeColor;
      }

      var logo = Properties.Resources.LOGO_TGM_ICONE.ApplyColor(this.menuSandwich.ForeColor);
      this.ptbLogo.Image = logo;

      FrmPrincipal.Instancia.Refresh();
      FrmPrincipal.Instancia.Invalidate();
    }

    private void SetarAparencia() {
      //if ((LmTheme)Style.model.Tema == LmTheme.Personalizado)
      //{
      //    Style.model.Tema = (int)LmTheme.Padrao;
      //}

      //this.Theme = (LmTheme)Style.model.Tema;
      //this.TipoMensagem = (LmMessageType)Style.model.TipoMensagem;
    }

    private void SetarBackGroundImage() {
      Invoke(new MethodInvoker(delegate () {
        this.pnlMain.BackgroundImage = Properties.Resources.LOGO_TGM_FUNDO;
        var logo = Properties.Resources.LOGO_TGM_ICONE.ApplyColor(this.menuSandwich.ForeColor);
        this.ptbLogo.Image = logo;
        this.tslVersao.ForeColor = 
        this.tslSecao.ForeColor = 
        this.tslConsumoMemoria.ForeColor = 
        this.tslFormAberto.ForeColor = this.menuSandwich.ForeColor;
      }));
    }

    private void ConfigurarRodape() {
      Invoke(new MethodInvoker(delegate () {
        tmrMemory.Enabled = true;
      }));
    }

    private void RemoverLinhasSeparacaoMenu(ToolStripItemCollection items) {
      System.Collections.IList list = items;
      for (int k = 0; k < items.Count; k++) {
        if (list[k] is ToolStripSeparator)
          continue;

        ToolStripMenuItem item = (ToolStripMenuItem)list[k];
        if (item.DropDownItems != null && item.DropDownItems.Count > 0) {
          for (int i = 1; i < item.DropDownItems.Count - 1; i++) {
            if (item.DropDownItems[i] is ToolStripSeparator && item.DropDownItems[i].Available) {
              bool ocultar = true;
              for (int h = i - 1; h >= 0; h--) {
                if (item.DropDownItems[h].Available && !(item.DropDownItems[h] is ToolStripSeparator)) {
                  ocultar = false;
                  break;
                } else if (item.DropDownItems[h].Available && item.DropDownItems[h] is ToolStripSeparator) {
                  break;
                }
              }
              if (ocultar) {
                item.DropDownItems[i].Visible = false;
                continue;
              }

              ocultar = true;
              for (int h = i + 1; h < item.DropDownItems.Count; h++) {
                if (item.DropDownItems[h].Available && !(item.DropDownItems[h] is ToolStripSeparator)) {
                  ocultar = false;
                  break;
                } else if (item.DropDownItems[h].Available && item.DropDownItems[h] is ToolStripSeparator) {
                  break;
                }
              }
              if (ocultar) {
                item.DropDownItems[i].Visible = false;
                continue;
              }
            }
          }
        }

        if (item.DropDownItems != null && item.DropDownItems.Count > 0)
          RemoverLinhasSeparacaoMenu(item.DropDownItems);
      }
    }

    private void VerMemoria() {
      try {
        var procs = System.Diagnostics.Process.GetProcessesByName("TGM_DRV");

        double tamanho = 0;
        short qty = 0;

        foreach (var proc in procs) {
          if (proc.PrivateMemorySize64 > 100000) {
            qty++;
            tamanho += Math.Round(proc.PrivateMemorySize64 / Math.Pow(1024d, 2d), 3);
          }
        }

        Invoke(new MethodInvoker(delegate () {
          tslConsumoMemoria.Text
              = tamanho < 1024
              ? $"{qty}X|{tamanho:#,###,##0.000} MB"
              : $"{qty}X|{tamanho / 1024:#,###,##0.000} GB";
        }));

        // Get Focused Control
        Invoke(new MethodInvoker(delegate () {
          //tslFocusedCtrl.Text = CorbieView.GetNameFocusedControl();
        }));

        if (pnlMain.Controls.Count > 0) {
          var container = pnlMain.Controls[0] as LmContainerForm;

          LmChildForm frm = container.Controls[0] as LmChildForm;

          ((ToolStripStatusLabel)((StatusStrip)this.Controls["stpRodape"]).Items["tslFormAberto"]).Text = frm.Name;
          ((ToolStripStatusLabel)((StatusStrip)this.Controls["stpRodape"]).Items["tslModo"]).Text = frm.MensagemRodape;
        } else {
          ((ToolStripStatusLabel)((StatusStrip)this.Controls["stpRodape"]).Items["tslFormAberto"]).Text = string.Empty;
          ((ToolStripStatusLabel)((StatusStrip)this.Controls["stpRodape"]).Items["tslModo"]).Text = string.Empty;
        }

        //GC.Collect();

        Invoke(new MethodInvoker(delegate () {
          tmrMemory.Enabled = true;
        }));

      } catch (ObjectDisposedException ex) {

      }
    }

    #endregion

    private void MenuDashboard_Click(object sender, EventArgs e) => OpenFormChild(new FrmDashboard());

    private void MenuConfigFtp_Click(object sender, EventArgs e) => OpenFormChild(new FrmConfigFTP());

    private void MenuConfigColunas_Click(object sender, EventArgs e) => OpenFormChild(new FrmColunas());

    private void MenuImportFtp_Click(object sender, EventArgs e) {
      FrmImportar frm = new FrmImportar();
      frm.ShowDialog();
    }

    private void MenuAparencia_Click(object sender, EventArgs e) => OpenFormChild(new FrmAparencia());

    private void MenuLogout_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void MenuSandwich_Click(object sender, EventArgs e) {
      if (ValorPredefinido.model.MostrarApenasIconeMenu)
        ValorPredefinido.model.MostrarApenasIconeMenu = false;
      else
        ValorPredefinido.model.MostrarApenasIconeMenu = true;

      this.pnlMain.BackgroundImage = null;
      PosicionarMenu();

      ValorPredefinido.Salvar();
    }
  }
}
