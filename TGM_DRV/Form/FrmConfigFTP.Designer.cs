namespace TGM_DRV {
  partial class FrmConfigFTP {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigFTP));
      this.btnSalvar = new LmCorbieUI.Controls.LmButton();
      this.lblNome = new LmCorbieUI.Controls.LmLabel();
      this.txtUsuario = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel1 = new LmCorbieUI.Controls.LmLabel();
      this.txtSenha = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel2 = new LmCorbieUI.Controls.LmLabel();
      this.txtDiretorio = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel3 = new LmCorbieUI.Controls.LmLabel();
      this.txtServer = new LmCorbieUI.Controls.LmTextBox();
      this.SuspendLayout();
      // 
      // btnSalvar
      // 
      this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnSalvar.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnSalvar.BorderRadius = 13;
      this.btnSalvar.BorderSize = 0;
      this.btnSalvar.Enabled = false;
      this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
      this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSalvar.Location = new System.Drawing.Point(121, 184);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(111, 26);
      this.btnSalvar.TabIndex = 4;
      this.btnSalvar.Text = " &Salvar";
      this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSalvar.UseVisualStyleBackColor = false;
      this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
      // 
      // lblNome
      // 
      this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lblNome.BackColor = System.Drawing.Color.Transparent;
      this.lblNome.Location = new System.Drawing.Point(20, 71);
      this.lblNome.Margin = new System.Windows.Forms.Padding(3);
      this.lblNome.Name = "lblNome";
      this.lblNome.Size = new System.Drawing.Size(95, 19);
      this.lblNome.TabIndex = 111;
      this.lblNome.Text = "Usuario FTP *";
      this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtUsuario
      // 
      this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtUsuario.BorderRadius = 15;
      this.txtUsuario.BorderSize = 2;
      this.txtUsuario.CampoObrigatorio = true;
      this.txtUsuario.F7ToolTipText = null;
      this.txtUsuario.F8ToolTipText = null;
      this.txtUsuario.F9ToolTipText = null;
      this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtUsuario.IconF7 = null;
      this.txtUsuario.IconToolTipText = null;
      this.txtUsuario.Lines = new string[0];
      this.txtUsuario.Location = new System.Drawing.Point(121, 65);
      this.txtUsuario.MaxLength = 80;
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.PasswordChar = '\0';
      this.txtUsuario.Propriedade = "Descricao";
      this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtUsuario.SelectedText = "";
      this.txtUsuario.SelectionLength = 0;
      this.txtUsuario.SelectionStart = 0;
      this.txtUsuario.ShortcutsEnabled = true;
      this.txtUsuario.Size = new System.Drawing.Size(334, 30);
      this.txtUsuario.TabIndex = 1;
      this.txtUsuario.UnderlinedStyle = false;
      this.txtUsuario.UseSelectable = true;
      this.txtUsuario.Valor_Decimais = ((short)(0));
      this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel1
      // 
      this.lmLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel1.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel1.Location = new System.Drawing.Point(20, 107);
      this.lmLabel1.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel1.Name = "lmLabel1";
      this.lmLabel1.Size = new System.Drawing.Size(95, 19);
      this.lmLabel1.TabIndex = 113;
      this.lmLabel1.Text = "Senha FTP *";
      this.lmLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtSenha
      // 
      this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtSenha.BorderRadius = 15;
      this.txtSenha.BorderSize = 2;
      this.txtSenha.CampoObrigatorio = true;
      this.txtSenha.F7ToolTipText = "Exibir Senha";
      this.txtSenha.F8ToolTipText = null;
      this.txtSenha.F9ToolTipText = null;
      this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtSenha.IconF7 = global::TGM_DRV.Properties.Resources.olho_aberto;
      this.txtSenha.IconToolTipText = null;
      this.txtSenha.Lines = new string[0];
      this.txtSenha.Location = new System.Drawing.Point(121, 101);
      this.txtSenha.MaxLength = 80;
      this.txtSenha.Name = "txtSenha";
      this.txtSenha.PasswordChar = '●';
      this.txtSenha.Propriedade = "Descricao";
      this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtSenha.SelectedText = "";
      this.txtSenha.SelectionLength = 0;
      this.txtSenha.SelectionStart = 0;
      this.txtSenha.ShortcutsEnabled = true;
      this.txtSenha.ShowButtonF7 = true;
      this.txtSenha.Size = new System.Drawing.Size(334, 30);
      this.txtSenha.TabIndex = 2;
      this.txtSenha.UnderlinedStyle = false;
      this.txtSenha.UseSelectable = true;
      this.txtSenha.UseSystemPasswordChar = true;
      this.txtSenha.Valor_Decimais = ((short)(0));
      this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      this.txtSenha.ButtonClickF7 += new LmCorbieUI.Controls.LmTextBox.ButClick(this.TxtSenha_ButtonClickF7);
      // 
      // lmLabel2
      // 
      this.lmLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel2.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel2.Location = new System.Drawing.Point(20, 143);
      this.lmLabel2.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel2.Name = "lmLabel2";
      this.lmLabel2.Size = new System.Drawing.Size(95, 19);
      this.lmLabel2.TabIndex = 115;
      this.lmLabel2.Text = "Subdiretório";
      this.lmLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtDiretorio
      // 
      this.txtDiretorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtDiretorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtDiretorio.BorderRadius = 15;
      this.txtDiretorio.BorderSize = 2;
      this.txtDiretorio.F7ToolTipText = null;
      this.txtDiretorio.F8ToolTipText = null;
      this.txtDiretorio.F9ToolTipText = null;
      this.txtDiretorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtDiretorio.IconF7 = null;
      this.txtDiretorio.IconToolTipText = null;
      this.txtDiretorio.Lines = new string[0];
      this.txtDiretorio.Location = new System.Drawing.Point(121, 137);
      this.txtDiretorio.MaxLength = 250;
      this.txtDiretorio.Name = "txtDiretorio";
      this.txtDiretorio.PasswordChar = '\0';
      this.txtDiretorio.Propriedade = "Descricao";
      this.txtDiretorio.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtDiretorio.SelectedText = "";
      this.txtDiretorio.SelectionLength = 0;
      this.txtDiretorio.SelectionStart = 0;
      this.txtDiretorio.ShortcutsEnabled = true;
      this.txtDiretorio.Size = new System.Drawing.Size(334, 30);
      this.txtDiretorio.TabIndex = 3;
      this.txtDiretorio.UnderlinedStyle = false;
      this.txtDiretorio.UseSelectable = true;
      this.txtDiretorio.Valor_Decimais = ((short)(0));
      this.txtDiretorio.WaterMark = "Ex: Pasta1/Pasta2/Pasta3";
      this.txtDiretorio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtDiretorio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel3
      // 
      this.lmLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel3.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel3.Location = new System.Drawing.Point(20, 35);
      this.lmLabel3.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel3.Name = "lmLabel3";
      this.lmLabel3.Size = new System.Drawing.Size(95, 19);
      this.lmLabel3.TabIndex = 117;
      this.lmLabel3.Text = "Servidor FTP *";
      this.lmLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtServer
      // 
      this.txtServer.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtServer.BorderRadius = 15;
      this.txtServer.BorderSize = 2;
      this.txtServer.CampoObrigatorio = true;
      this.txtServer.F7ToolTipText = null;
      this.txtServer.F8ToolTipText = null;
      this.txtServer.F9ToolTipText = null;
      this.txtServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtServer.IconF7 = null;
      this.txtServer.IconToolTipText = null;
      this.txtServer.Lines = new string[0];
      this.txtServer.Location = new System.Drawing.Point(121, 29);
      this.txtServer.MaxLength = 80;
      this.txtServer.Name = "txtServer";
      this.txtServer.PasswordChar = '\0';
      this.txtServer.Propriedade = "Descricao";
      this.txtServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtServer.SelectedText = "";
      this.txtServer.SelectionLength = 0;
      this.txtServer.SelectionStart = 0;
      this.txtServer.ShortcutsEnabled = true;
      this.txtServer.Size = new System.Drawing.Size(334, 30);
      this.txtServer.TabIndex = 0;
      this.txtServer.UnderlinedStyle = false;
      this.txtServer.UseSelectable = true;
      this.txtServer.Valor_Decimais = ((short)(0));
      this.txtServer.WaterMark = "Ex: ftp://host";
      this.txtServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // FrmConfigFTP
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(508, 244);
      this.Controls.Add(this.lmLabel3);
      this.Controls.Add(this.txtServer);
      this.Controls.Add(this.lmLabel2);
      this.Controls.Add(this.txtDiretorio);
      this.Controls.Add(this.lmLabel1);
      this.Controls.Add(this.txtSenha);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.lblNome);
      this.Controls.Add(this.txtUsuario);
      this.Name = "FrmConfigFTP";
      this.Text = "Configurar FTP";
      this.Loaded += new LmCorbieUI.LmForms.LmChildForm.FormLoad(this.FrmConfigFTP_Loaded);
      this.ResumeLayout(false);

    }

    #endregion

    private LmCorbieUI.Controls.LmButton btnSalvar;
    private LmCorbieUI.Controls.LmLabel lblNome;
    private LmCorbieUI.Controls.LmTextBox txtUsuario;
    private LmCorbieUI.Controls.LmLabel lmLabel1;
    private LmCorbieUI.Controls.LmTextBox txtSenha;
    private LmCorbieUI.Controls.LmLabel lmLabel2;
    private LmCorbieUI.Controls.LmTextBox txtDiretorio;
    private LmCorbieUI.Controls.LmLabel lmLabel3;
    private LmCorbieUI.Controls.LmTextBox txtServer;
  }
}