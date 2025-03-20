namespace TGM_DRV {
  partial class FrmEmpresa {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
      this.btnSalvar = new LmCorbieUI.Controls.LmButton();
      this.lblNome = new LmCorbieUI.Controls.LmLabel();
      this.txtCep = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel1 = new LmCorbieUI.Controls.LmLabel();
      this.txtEndereco = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel2 = new LmCorbieUI.Controls.LmLabel();
      this.txtBairro = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel3 = new LmCorbieUI.Controls.LmLabel();
      this.txtRazaoSocial = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel4 = new LmCorbieUI.Controls.LmLabel();
      this.txtNumeroEndereco = new LmCorbieUI.Controls.LmTextBox();
      this.txtCidade = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel5 = new LmCorbieUI.Controls.LmLabel();
      this.txtEstado = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel6 = new LmCorbieUI.Controls.LmLabel();
      this.txtFone = new LmCorbieUI.Controls.LmTextBox();
      this.lmLabel7 = new LmCorbieUI.Controls.LmLabel();
      this.ptbImagem = new System.Windows.Forms.PictureBox();
      this.btnLogo = new LmCorbieUI.Controls.LmButton();
      ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).BeginInit();
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
      this.btnSalvar.Location = new System.Drawing.Point(119, 320);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(111, 26);
      this.btnSalvar.TabIndex = 8;
      this.btnSalvar.Text = " &Salvar";
      this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSalvar.UseVisualStyleBackColor = false;
      this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
      // 
      // lblNome
      // 
      this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lblNome.BackColor = System.Drawing.Color.Transparent;
      this.lblNome.Location = new System.Drawing.Point(7, 99);
      this.lblNome.Margin = new System.Windows.Forms.Padding(3);
      this.lblNome.Name = "lblNome";
      this.lblNome.Size = new System.Drawing.Size(106, 19);
      this.lblNome.TabIndex = 111;
      this.lblNome.Text = "Cep *";
      this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtCep
      // 
      this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtCep.BorderRadius = 15;
      this.txtCep.BorderSize = 2;
      this.txtCep.CampoObrigatorio = true;
      this.txtCep.F7ToolTipText = null;
      this.txtCep.F8ToolTipText = null;
      this.txtCep.F9ToolTipText = null;
      this.txtCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtCep.IconF7 = null;
      this.txtCep.IconToolTipText = null;
      this.txtCep.Lines = new string[0];
      this.txtCep.Location = new System.Drawing.Point(119, 93);
      this.txtCep.MaxLength = 9;
      this.txtCep.Name = "txtCep";
      this.txtCep.PasswordChar = '\0';
      this.txtCep.Propriedade = null;
      this.txtCep.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtCep.SelectedText = "";
      this.txtCep.SelectionLength = 0;
      this.txtCep.SelectionStart = 0;
      this.txtCep.ShortcutsEnabled = true;
      this.txtCep.Size = new System.Drawing.Size(334, 30);
      this.txtCep.TabIndex = 2;
      this.txtCep.UnderlinedStyle = false;
      this.txtCep.UseSelectable = true;
      this.txtCep.Valor_Decimais = ((short)(0));
      this.txtCep.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtCep.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel1
      // 
      this.lmLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel1.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel1.Location = new System.Drawing.Point(7, 135);
      this.lmLabel1.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel1.Name = "lmLabel1";
      this.lmLabel1.Size = new System.Drawing.Size(106, 19);
      this.lmLabel1.TabIndex = 113;
      this.lmLabel1.Text = "Endereço *";
      this.lmLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtEndereco
      // 
      this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtEndereco.BorderRadius = 15;
      this.txtEndereco.BorderSize = 2;
      this.txtEndereco.CampoObrigatorio = true;
      this.txtEndereco.F7ToolTipText = "";
      this.txtEndereco.F8ToolTipText = null;
      this.txtEndereco.F9ToolTipText = null;
      this.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtEndereco.IconF7 = global::TGM_DRV.Properties.Resources.olho_aberto;
      this.txtEndereco.IconToolTipText = null;
      this.txtEndereco.Lines = new string[0];
      this.txtEndereco.Location = new System.Drawing.Point(119, 129);
      this.txtEndereco.MaxLength = 50;
      this.txtEndereco.Name = "txtEndereco";
      this.txtEndereco.PasswordChar = '\0';
      this.txtEndereco.Propriedade = null;
      this.txtEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtEndereco.SelectedText = "";
      this.txtEndereco.SelectionLength = 0;
      this.txtEndereco.SelectionStart = 0;
      this.txtEndereco.ShortcutsEnabled = true;
      this.txtEndereco.Size = new System.Drawing.Size(334, 30);
      this.txtEndereco.TabIndex = 3;
      this.txtEndereco.UnderlinedStyle = false;
      this.txtEndereco.UseSelectable = true;
      this.txtEndereco.Valor_Decimais = ((short)(0));
      this.txtEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel2
      // 
      this.lmLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel2.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel2.Location = new System.Drawing.Point(7, 207);
      this.lmLabel2.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel2.Name = "lmLabel2";
      this.lmLabel2.Size = new System.Drawing.Size(106, 19);
      this.lmLabel2.TabIndex = 115;
      this.lmLabel2.Text = "Bairro *";
      this.lmLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtBairro
      // 
      this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtBairro.BorderRadius = 15;
      this.txtBairro.BorderSize = 2;
      this.txtBairro.CampoObrigatorio = true;
      this.txtBairro.F7ToolTipText = null;
      this.txtBairro.F8ToolTipText = null;
      this.txtBairro.F9ToolTipText = null;
      this.txtBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtBairro.IconF7 = null;
      this.txtBairro.IconToolTipText = null;
      this.txtBairro.Lines = new string[0];
      this.txtBairro.Location = new System.Drawing.Point(119, 201);
      this.txtBairro.MaxLength = 50;
      this.txtBairro.Name = "txtBairro";
      this.txtBairro.PasswordChar = '\0';
      this.txtBairro.Propriedade = "Descricao";
      this.txtBairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtBairro.SelectedText = "";
      this.txtBairro.SelectionLength = 0;
      this.txtBairro.SelectionStart = 0;
      this.txtBairro.ShortcutsEnabled = true;
      this.txtBairro.Size = new System.Drawing.Size(334, 30);
      this.txtBairro.TabIndex = 5;
      this.txtBairro.UnderlinedStyle = false;
      this.txtBairro.UseSelectable = true;
      this.txtBairro.Valor_Decimais = ((short)(0));
      this.txtBairro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtBairro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel3
      // 
      this.lmLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel3.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel3.Location = new System.Drawing.Point(7, 27);
      this.lmLabel3.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel3.Name = "lmLabel3";
      this.lmLabel3.Size = new System.Drawing.Size(106, 19);
      this.lmLabel3.TabIndex = 117;
      this.lmLabel3.Text = "Razão Social *";
      this.lmLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtRazaoSocial
      // 
      this.txtRazaoSocial.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtRazaoSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtRazaoSocial.BorderRadius = 15;
      this.txtRazaoSocial.BorderSize = 2;
      this.txtRazaoSocial.CampoObrigatorio = true;
      this.txtRazaoSocial.F7ToolTipText = null;
      this.txtRazaoSocial.F8ToolTipText = null;
      this.txtRazaoSocial.F9ToolTipText = null;
      this.txtRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtRazaoSocial.IconF7 = null;
      this.txtRazaoSocial.IconToolTipText = null;
      this.txtRazaoSocial.Lines = new string[0];
      this.txtRazaoSocial.Location = new System.Drawing.Point(119, 21);
      this.txtRazaoSocial.MaxLength = 80;
      this.txtRazaoSocial.Name = "txtRazaoSocial";
      this.txtRazaoSocial.PasswordChar = '\0';
      this.txtRazaoSocial.Propriedade = null;
      this.txtRazaoSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtRazaoSocial.SelectedText = "";
      this.txtRazaoSocial.SelectionLength = 0;
      this.txtRazaoSocial.SelectionStart = 0;
      this.txtRazaoSocial.ShortcutsEnabled = true;
      this.txtRazaoSocial.Size = new System.Drawing.Size(334, 30);
      this.txtRazaoSocial.TabIndex = 0;
      this.txtRazaoSocial.UnderlinedStyle = false;
      this.txtRazaoSocial.UseSelectable = true;
      this.txtRazaoSocial.Valor_Decimais = ((short)(0));
      this.txtRazaoSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtRazaoSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel4
      // 
      this.lmLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel4.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel4.Location = new System.Drawing.Point(7, 171);
      this.lmLabel4.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel4.Name = "lmLabel4";
      this.lmLabel4.Size = new System.Drawing.Size(106, 19);
      this.lmLabel4.TabIndex = 119;
      this.lmLabel4.Text = "Nº Endereço *";
      this.lmLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtNumeroEndereco
      // 
      this.txtNumeroEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtNumeroEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtNumeroEndereco.BorderRadius = 15;
      this.txtNumeroEndereco.BorderSize = 2;
      this.txtNumeroEndereco.CampoObrigatorio = true;
      this.txtNumeroEndereco.F7ToolTipText = "";
      this.txtNumeroEndereco.F8ToolTipText = null;
      this.txtNumeroEndereco.F9ToolTipText = null;
      this.txtNumeroEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtNumeroEndereco.IconF7 = global::TGM_DRV.Properties.Resources.olho_aberto;
      this.txtNumeroEndereco.IconToolTipText = null;
      this.txtNumeroEndereco.Lines = new string[0];
      this.txtNumeroEndereco.Location = new System.Drawing.Point(119, 165);
      this.txtNumeroEndereco.MaxLength = 6;
      this.txtNumeroEndereco.Name = "txtNumeroEndereco";
      this.txtNumeroEndereco.PasswordChar = '\0';
      this.txtNumeroEndereco.Propriedade = "Descricao";
      this.txtNumeroEndereco.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtNumeroEndereco.SelectedText = "";
      this.txtNumeroEndereco.SelectionLength = 0;
      this.txtNumeroEndereco.SelectionStart = 0;
      this.txtNumeroEndereco.ShortcutsEnabled = true;
      this.txtNumeroEndereco.Size = new System.Drawing.Size(334, 30);
      this.txtNumeroEndereco.TabIndex = 4;
      this.txtNumeroEndereco.UnderlinedStyle = false;
      this.txtNumeroEndereco.UseSelectable = true;
      this.txtNumeroEndereco.Valor_Decimais = ((short)(0));
      this.txtNumeroEndereco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtNumeroEndereco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // txtCidade
      // 
      this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtCidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtCidade.BorderRadius = 15;
      this.txtCidade.BorderSize = 2;
      this.txtCidade.CampoObrigatorio = true;
      this.txtCidade.F7ToolTipText = null;
      this.txtCidade.F8ToolTipText = null;
      this.txtCidade.F9ToolTipText = null;
      this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtCidade.IconF7 = null;
      this.txtCidade.IconToolTipText = null;
      this.txtCidade.Lines = new string[0];
      this.txtCidade.Location = new System.Drawing.Point(119, 237);
      this.txtCidade.MaxLength = 50;
      this.txtCidade.Name = "txtCidade";
      this.txtCidade.PasswordChar = '\0';
      this.txtCidade.Propriedade = "Descricao";
      this.txtCidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtCidade.SelectedText = "";
      this.txtCidade.SelectionLength = 0;
      this.txtCidade.SelectionStart = 0;
      this.txtCidade.ShortcutsEnabled = true;
      this.txtCidade.Size = new System.Drawing.Size(334, 30);
      this.txtCidade.TabIndex = 6;
      this.txtCidade.UnderlinedStyle = false;
      this.txtCidade.UseSelectable = true;
      this.txtCidade.Valor_Decimais = ((short)(0));
      this.txtCidade.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtCidade.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel5
      // 
      this.lmLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel5.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel5.Location = new System.Drawing.Point(7, 243);
      this.lmLabel5.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel5.Name = "lmLabel5";
      this.lmLabel5.Size = new System.Drawing.Size(106, 19);
      this.lmLabel5.TabIndex = 115;
      this.lmLabel5.Text = "Cidade *";
      this.lmLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtEstado
      // 
      this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtEstado.BorderRadius = 15;
      this.txtEstado.BorderSize = 2;
      this.txtEstado.CampoObrigatorio = true;
      this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtEstado.F7ToolTipText = null;
      this.txtEstado.F8ToolTipText = null;
      this.txtEstado.F9ToolTipText = null;
      this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtEstado.IconF7 = null;
      this.txtEstado.IconToolTipText = null;
      this.txtEstado.Lines = new string[0];
      this.txtEstado.Location = new System.Drawing.Point(119, 273);
      this.txtEstado.MaxLength = 2;
      this.txtEstado.Name = "txtEstado";
      this.txtEstado.PasswordChar = '\0';
      this.txtEstado.Propriedade = "Descricao";
      this.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtEstado.SelectedText = "";
      this.txtEstado.SelectionLength = 0;
      this.txtEstado.SelectionStart = 0;
      this.txtEstado.ShortcutsEnabled = true;
      this.txtEstado.Size = new System.Drawing.Size(334, 30);
      this.txtEstado.TabIndex = 7;
      this.txtEstado.UnderlinedStyle = false;
      this.txtEstado.UseSelectable = true;
      this.txtEstado.Valor_Decimais = ((short)(0));
      this.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtEstado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel6
      // 
      this.lmLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel6.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel6.Location = new System.Drawing.Point(7, 279);
      this.lmLabel6.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel6.Name = "lmLabel6";
      this.lmLabel6.Size = new System.Drawing.Size(106, 19);
      this.lmLabel6.TabIndex = 115;
      this.lmLabel6.Text = "Estado *";
      this.lmLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // txtFone
      // 
      this.txtFone.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.txtFone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtFone.BorderRadius = 15;
      this.txtFone.BorderSize = 2;
      this.txtFone.CampoObrigatorio = true;
      this.txtFone.F7ToolTipText = null;
      this.txtFone.F8ToolTipText = null;
      this.txtFone.F9ToolTipText = null;
      this.txtFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtFone.IconF7 = null;
      this.txtFone.IconToolTipText = null;
      this.txtFone.Lines = new string[0];
      this.txtFone.Location = new System.Drawing.Point(119, 57);
      this.txtFone.MaxLength = 20;
      this.txtFone.Name = "txtFone";
      this.txtFone.PasswordChar = '\0';
      this.txtFone.Propriedade = null;
      this.txtFone.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtFone.SelectedText = "";
      this.txtFone.SelectionLength = 0;
      this.txtFone.SelectionStart = 0;
      this.txtFone.ShortcutsEnabled = true;
      this.txtFone.Size = new System.Drawing.Size(334, 30);
      this.txtFone.TabIndex = 1;
      this.txtFone.UnderlinedStyle = false;
      this.txtFone.UseSelectable = true;
      this.txtFone.Valor = LmCorbieUI.Design.LmValueType.Fone;
      this.txtFone.Valor_Decimais = ((short)(0));
      this.txtFone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtFone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // lmLabel7
      // 
      this.lmLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.lmLabel7.BackColor = System.Drawing.Color.Transparent;
      this.lmLabel7.Location = new System.Drawing.Point(7, 63);
      this.lmLabel7.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel7.Name = "lmLabel7";
      this.lmLabel7.Size = new System.Drawing.Size(106, 19);
      this.lmLabel7.TabIndex = 111;
      this.lmLabel7.Text = "Fone *";
      this.lmLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // ptbImagem
      // 
      this.ptbImagem.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.ptbImagem.BackColor = System.Drawing.Color.Transparent;
      this.ptbImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ptbImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ptbImagem.Location = new System.Drawing.Point(460, 20);
      this.ptbImagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.ptbImagem.Name = "ptbImagem";
      this.ptbImagem.Size = new System.Drawing.Size(255, 139);
      this.ptbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.ptbImagem.TabIndex = 432;
      this.ptbImagem.TabStop = false;
      this.ptbImagem.Tag = "limpar";
      // 
      // btnLogo
      // 
      this.btnLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnLogo.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnLogo.BorderRadius = 13;
      this.btnLogo.BorderSize = 0;
      this.btnLogo.Enabled = false;
      this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
      this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnLogo.Location = new System.Drawing.Point(460, 165);
      this.btnLogo.Name = "btnLogo";
      this.btnLogo.Size = new System.Drawing.Size(255, 26);
      this.btnLogo.TabIndex = 433;
      this.btnLogo.Text = " Selecionar Logo Empresa";
      this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnLogo.UseVisualStyleBackColor = false;
      this.btnLogo.Click += new System.EventHandler(this.BtnLogo_Click);
      // 
      // FrmEmpresa
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(733, 405);
      this.Controls.Add(this.btnLogo);
      this.Controls.Add(this.ptbImagem);
      this.Controls.Add(this.lmLabel4);
      this.Controls.Add(this.txtNumeroEndereco);
      this.Controls.Add(this.lmLabel3);
      this.Controls.Add(this.txtRazaoSocial);
      this.Controls.Add(this.lmLabel6);
      this.Controls.Add(this.lmLabel5);
      this.Controls.Add(this.lmLabel2);
      this.Controls.Add(this.txtEstado);
      this.Controls.Add(this.txtCidade);
      this.Controls.Add(this.txtBairro);
      this.Controls.Add(this.lmLabel1);
      this.Controls.Add(this.txtEndereco);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.lmLabel7);
      this.Controls.Add(this.lblNome);
      this.Controls.Add(this.txtFone);
      this.Controls.Add(this.txtCep);
      this.Name = "FrmEmpresa";
      this.Text = "Dados Empresa";
      this.Loaded += new LmCorbieUI.LmForms.LmChildForm.FormLoad(this.FrmEmpresa_Loaded);
      ((System.ComponentModel.ISupportInitialize)(this.ptbImagem)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private LmCorbieUI.Controls.LmButton btnSalvar;
    private LmCorbieUI.Controls.LmLabel lblNome;
    private LmCorbieUI.Controls.LmTextBox txtCep;
    private LmCorbieUI.Controls.LmLabel lmLabel1;
    private LmCorbieUI.Controls.LmTextBox txtEndereco;
    private LmCorbieUI.Controls.LmLabel lmLabel2;
    private LmCorbieUI.Controls.LmTextBox txtBairro;
    private LmCorbieUI.Controls.LmLabel lmLabel3;
    private LmCorbieUI.Controls.LmTextBox txtRazaoSocial;
    private LmCorbieUI.Controls.LmLabel lmLabel4;
    private LmCorbieUI.Controls.LmTextBox txtNumeroEndereco;
    private LmCorbieUI.Controls.LmTextBox txtCidade;
    private LmCorbieUI.Controls.LmLabel lmLabel5;
    private LmCorbieUI.Controls.LmTextBox txtEstado;
    private LmCorbieUI.Controls.LmLabel lmLabel6;
    private LmCorbieUI.Controls.LmTextBox txtFone;
    private LmCorbieUI.Controls.LmLabel lmLabel7;
    private System.Windows.Forms.PictureBox ptbImagem;
    private LmCorbieUI.Controls.LmButton btnLogo;
  }
}