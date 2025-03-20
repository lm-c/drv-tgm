namespace TGM_DRV {
  partial class FrmPrincipal {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
      this.pnlMenu = new LmCorbieUI.Controls.LmPanel();
      this.menuImportFtp = new LmCorbieUI.Controls.LmMenuItem();
      this.menuConfigColunas = new LmCorbieUI.Controls.LmMenuItem();
      this.menuAparencia = new LmCorbieUI.Controls.LmMenuItem();
      this.menuConfigFtp = new LmCorbieUI.Controls.LmMenuItem();
      this.menuDashboard = new LmCorbieUI.Controls.LmMenuItem();
      this.menuLogout = new LmCorbieUI.Controls.LmMenuItem();
      this.pnlLogo = new LmCorbieUI.Controls.LmPanel();
      this.menuSandwich = new LmCorbieUI.Controls.LmMenuItem();
      this.ptbLogo = new System.Windows.Forms.PictureBox();
      this.stpRodape = new LmCorbieUI.Controls.LmStatusStrip();
      this.tslVersao = new System.Windows.Forms.ToolStripStatusLabel();
      this.tslSecao = new System.Windows.Forms.ToolStripStatusLabel();
      this.tslConsumoMemoria = new System.Windows.Forms.ToolStripStatusLabel();
      this.tslFormAberto = new System.Windows.Forms.ToolStripStatusLabel();
      this.tslModo = new System.Windows.Forms.ToolStripStatusLabel();
      this.msMenuJanelaAberta = new LmCorbieUI.Controls.LmMenuJanelaAberta();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.tmrMemory = new System.Windows.Forms.Timer(this.components);
      this.pnlMain = new LmCorbieUI.Controls.LmPanel();
      this.menuDadosEmpresa = new LmCorbieUI.Controls.LmMenuItem();
      this.pnlMenu.SuspendLayout();
      this.pnlLogo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
      this.stpRodape.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlMenu
      // 
      this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
      this.pnlMenu.Controls.Add(this.menuDadosEmpresa);
      this.pnlMenu.Controls.Add(this.menuImportFtp);
      this.pnlMenu.Controls.Add(this.menuConfigColunas);
      this.pnlMenu.Controls.Add(this.menuAparencia);
      this.pnlMenu.Controls.Add(this.menuConfigFtp);
      this.pnlMenu.Controls.Add(this.menuDashboard);
      this.pnlMenu.Controls.Add(this.menuLogout);
      this.pnlMenu.Controls.Add(this.pnlLogo);
      this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlMenu.IsPanelMenu = true;
      this.pnlMenu.Location = new System.Drawing.Point(2, 26);
      this.pnlMenu.Name = "pnlMenu";
      this.pnlMenu.Size = new System.Drawing.Size(193, 550);
      this.pnlMenu.TabIndex = 1;
      // 
      // menuImportFtp
      // 
      this.menuImportFtp.Dock = System.Windows.Forms.DockStyle.Top;
      this.menuImportFtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuImportFtp.Image = ((System.Drawing.Image)(resources.GetObject("menuImportFtp.Image")));
      this.menuImportFtp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuImportFtp.Location = new System.Drawing.Point(0, 142);
      this.menuImportFtp.Name = "menuImportFtp";
      this.menuImportFtp.Size = new System.Drawing.Size(193, 30);
      this.menuImportFtp.TabIndex = 5;
      this.menuImportFtp.TabStop = false;
      this.menuImportFtp.Text = "   Importar Dados do FTP";
      this.menuImportFtp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuImportFtp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.menuImportFtp.UseSelectable = true;
      this.menuImportFtp.UseVisualStyleBackColor = false;
      this.menuImportFtp.Click += new System.EventHandler(this.MenuImportFtp_Click);
      // 
      // menuConfigColunas
      // 
      this.menuConfigColunas.Dock = System.Windows.Forms.DockStyle.Top;
      this.menuConfigColunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuConfigColunas.Image = ((System.Drawing.Image)(resources.GetObject("menuConfigColunas.Image")));
      this.menuConfigColunas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuConfigColunas.Location = new System.Drawing.Point(0, 112);
      this.menuConfigColunas.Name = "menuConfigColunas";
      this.menuConfigColunas.Size = new System.Drawing.Size(193, 30);
      this.menuConfigColunas.TabIndex = 11;
      this.menuConfigColunas.TabStop = false;
      this.menuConfigColunas.Text = "   Configurar Colunas";
      this.menuConfigColunas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuConfigColunas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.menuConfigColunas.UseSelectable = true;
      this.menuConfigColunas.UseVisualStyleBackColor = false;
      this.menuConfigColunas.Click += new System.EventHandler(this.MenuConfigColunas_Click);
      // 
      // menuAparencia
      // 
      this.menuAparencia.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.menuAparencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuAparencia.Image = ((System.Drawing.Image)(resources.GetObject("menuAparencia.Image")));
      this.menuAparencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuAparencia.Location = new System.Drawing.Point(0, 490);
      this.menuAparencia.Name = "menuAparencia";
      this.menuAparencia.Size = new System.Drawing.Size(193, 30);
      this.menuAparencia.TabIndex = 10;
      this.menuAparencia.TabStop = false;
      this.menuAparencia.Text = "   Aparência";
      this.menuAparencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuAparencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.menuAparencia.UseSelectable = true;
      this.menuAparencia.UseVisualStyleBackColor = false;
      this.menuAparencia.Click += new System.EventHandler(this.MenuAparencia_Click);
      // 
      // menuConfigFtp
      // 
      this.menuConfigFtp.Dock = System.Windows.Forms.DockStyle.Top;
      this.menuConfigFtp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuConfigFtp.Image = ((System.Drawing.Image)(resources.GetObject("menuConfigFtp.Image")));
      this.menuConfigFtp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuConfigFtp.Location = new System.Drawing.Point(0, 82);
      this.menuConfigFtp.Name = "menuConfigFtp";
      this.menuConfigFtp.Size = new System.Drawing.Size(193, 30);
      this.menuConfigFtp.TabIndex = 4;
      this.menuConfigFtp.TabStop = false;
      this.menuConfigFtp.Text = "   Configurar FTP";
      this.menuConfigFtp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuConfigFtp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.menuConfigFtp.UseSelectable = true;
      this.menuConfigFtp.UseVisualStyleBackColor = false;
      this.menuConfigFtp.Click += new System.EventHandler(this.MenuConfigFtp_Click);
      // 
      // menuDashboard
      // 
      this.menuDashboard.Dock = System.Windows.Forms.DockStyle.Top;
      this.menuDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuDashboard.Image = ((System.Drawing.Image)(resources.GetObject("menuDashboard.Image")));
      this.menuDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuDashboard.Location = new System.Drawing.Point(0, 52);
      this.menuDashboard.Name = "menuDashboard";
      this.menuDashboard.Size = new System.Drawing.Size(193, 30);
      this.menuDashboard.TabIndex = 3;
      this.menuDashboard.TabStop = false;
      this.menuDashboard.Text = "   Dashboard";
      this.menuDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.menuDashboard.UseSelectable = true;
      this.menuDashboard.UseVisualStyleBackColor = false;
      this.menuDashboard.Click += new System.EventHandler(this.MenuDashboard_Click);
      // 
      // menuLogout
      // 
      this.menuLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.menuLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuLogout.Image = ((System.Drawing.Image)(resources.GetObject("menuLogout.Image")));
      this.menuLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuLogout.Location = new System.Drawing.Point(0, 520);
      this.menuLogout.Name = "menuLogout";
      this.menuLogout.Size = new System.Drawing.Size(193, 30);
      this.menuLogout.TabIndex = 2;
      this.menuLogout.TabStop = false;
      this.menuLogout.Text = "   Sair";
      this.menuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.menuLogout.UseSelectable = true;
      this.menuLogout.UseVisualStyleBackColor = false;
      this.menuLogout.Click += new System.EventHandler(this.MenuLogout_Click);
      // 
      // pnlLogo
      // 
      this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
      this.pnlLogo.Controls.Add(this.menuSandwich);
      this.pnlLogo.Controls.Add(this.ptbLogo);
      this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlLogo.IsPanelMenu = true;
      this.pnlLogo.Location = new System.Drawing.Point(0, 0);
      this.pnlLogo.Name = "pnlLogo";
      this.pnlLogo.Size = new System.Drawing.Size(193, 52);
      this.pnlLogo.TabIndex = 0;
      // 
      // menuSandwich
      // 
      this.menuSandwich.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.menuSandwich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuSandwich.Image = ((System.Drawing.Image)(resources.GetObject("menuSandwich.Image")));
      this.menuSandwich.Location = new System.Drawing.Point(72, 26);
      this.menuSandwich.Name = "menuSandwich";
      this.menuSandwich.Size = new System.Drawing.Size(121, 26);
      this.menuSandwich.TabIndex = 1;
      this.menuSandwich.TabStop = false;
      this.menuSandwich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.menuSandwich.UseSelectable = true;
      this.menuSandwich.UseVisualStyleBackColor = false;
      this.menuSandwich.Click += new System.EventHandler(this.MenuSandwich_Click);
      // 
      // ptbLogo
      // 
      this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Left;
      this.ptbLogo.Location = new System.Drawing.Point(0, 0);
      this.ptbLogo.Name = "ptbLogo";
      this.ptbLogo.Size = new System.Drawing.Size(72, 52);
      this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.ptbLogo.TabIndex = 0;
      this.ptbLogo.TabStop = false;
      // 
      // stpRodape
      // 
      this.stpRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
      this.stpRodape.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.stpRodape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.stpRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslVersao,
            this.tslSecao,
            this.tslConsumoMemoria,
            this.tslFormAberto,
            this.tslModo});
      this.stpRodape.Location = new System.Drawing.Point(2, 576);
      this.stpRodape.Name = "stpRodape";
      this.stpRodape.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
      this.stpRodape.Size = new System.Drawing.Size(896, 22);
      this.stpRodape.SizingGrip = false;
      this.stpRodape.TabIndex = 3;
      this.stpRodape.Text = "lmStatusStrip1";
      // 
      // tslVersao
      // 
      this.tslVersao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tslVersao.Name = "tslVersao";
      this.tslVersao.Size = new System.Drawing.Size(44, 17);
      this.tslVersao.Text = "Versão:";
      // 
      // tslSecao
      // 
      this.tslSecao.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.tslSecao.Name = "tslSecao";
      this.tslSecao.Size = new System.Drawing.Size(40, 17);
      this.tslSecao.Text = "Seção:";
      // 
      // tslConsumoMemoria
      // 
      this.tslConsumoMemoria.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
      this.tslConsumoMemoria.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.tslConsumoMemoria.Name = "tslConsumoMemoria";
      this.tslConsumoMemoria.Size = new System.Drawing.Size(56, 17);
      this.tslConsumoMemoria.Text = "Memória";
      // 
      // tslFormAberto
      // 
      this.tslFormAberto.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
      this.tslFormAberto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.tslFormAberto.Name = "tslFormAberto";
      this.tslFormAberto.Size = new System.Drawing.Size(75, 17);
      this.tslFormAberto.Text = "Form Aberto";
      // 
      // tslModo
      // 
      this.tslModo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
      this.tslModo.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
      this.tslModo.Name = "tslModo";
      this.tslModo.Size = new System.Drawing.Size(102, 17);
      this.tslModo.Tag = "MsgRodape";
      this.tslModo.Text = "Inserindo Registro";
      // 
      // msMenuJanelaAberta
      // 
      this.msMenuJanelaAberta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
      this.msMenuJanelaAberta.Dock = System.Windows.Forms.DockStyle.Top;
      this.msMenuJanelaAberta.Location = new System.Drawing.Point(195, 26);
      this.msMenuJanelaAberta.Name = "msMenuJanelaAberta";
      this.msMenuJanelaAberta.Size = new System.Drawing.Size(703, 21);
      this.msMenuJanelaAberta.TabIndex = 4;
      this.msMenuJanelaAberta.UseSelectable = true;
      // 
      // tmrMemory
      // 
      this.tmrMemory.Interval = 1000;
      this.tmrMemory.Tag = "0";
      this.tmrMemory.Tick += new System.EventHandler(this.TmrMemory_Tick);
      // 
      // pnlMain
      // 
      this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
      this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlMain.IsPanelMenu = false;
      this.pnlMain.Location = new System.Drawing.Point(195, 47);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Size = new System.Drawing.Size(703, 529);
      this.pnlMain.TabIndex = 5;
      // 
      // menuDadosEmpresa
      // 
      this.menuDadosEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
      this.menuDadosEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.menuDadosEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("menuDadosEmpresa.Image")));
      this.menuDadosEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuDadosEmpresa.Location = new System.Drawing.Point(0, 172);
      this.menuDadosEmpresa.Name = "menuDadosEmpresa";
      this.menuDadosEmpresa.Size = new System.Drawing.Size(193, 30);
      this.menuDadosEmpresa.TabIndex = 12;
      this.menuDadosEmpresa.TabStop = false;
      this.menuDadosEmpresa.Text = "   Dados Empresa";
      this.menuDadosEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.menuDadosEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.menuDadosEmpresa.UseSelectable = true;
      this.menuDadosEmpresa.UseVisualStyleBackColor = false;
      this.menuDadosEmpresa.Click += new System.EventHandler(this.MenuDadosEmpresa_Click);
      // 
      // FrmPrincipal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(900, 600);
      this.Controls.Add(this.pnlMain);
      this.Controls.Add(this.msMenuJanelaAberta);
      this.Controls.Add(this.pnlMenu);
      this.Controls.Add(this.stpRodape);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(0, 0);
      this.MinimumSize = new System.Drawing.Size(900, 600);
      this.Name = "FrmPrincipal";
      this.Padding = new System.Windows.Forms.Padding(2, 26, 2, 2);
      this.Text = "FrmPrincipal";
      this.TextAlign = LmCorbieUI.LmForms.LmFormTextAlign.Center;
      this.Loaded += new LmCorbieUI.LmForms.LmMainForm.FormLoad(this.FrmPrincipal_Loaded);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
      this.Load += new System.EventHandler(this.FrmPrincipal_Load);
      this.pnlMenu.ResumeLayout(false);
      this.pnlLogo.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
      this.stpRodape.ResumeLayout(false);
      this.stpRodape.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal LmCorbieUI.Controls.LmPanel pnlMenu;
    private LmCorbieUI.Controls.LmMenuItem menuAparencia;
    private LmCorbieUI.Controls.LmMenuItem menuImportFtp;
    private LmCorbieUI.Controls.LmMenuItem menuConfigFtp;
    private LmCorbieUI.Controls.LmMenuItem menuDashboard;
    private LmCorbieUI.Controls.LmMenuItem menuLogout;
    private LmCorbieUI.Controls.LmPanel pnlLogo;
    internal LmCorbieUI.Controls.LmMenuItem menuSandwich;
    private System.Windows.Forms.PictureBox ptbLogo;
    private LmCorbieUI.Controls.LmStatusStrip stpRodape;
    private System.Windows.Forms.ToolStripStatusLabel tslVersao;
    private System.Windows.Forms.ToolStripStatusLabel tslSecao;
    private System.Windows.Forms.ToolStripStatusLabel tslFormAberto;
    private System.Windows.Forms.ToolStripStatusLabel tslModo;
    private LmCorbieUI.Controls.LmMenuJanelaAberta msMenuJanelaAberta;
    internal LmCorbieUI.Controls.LmPanel pnlMain;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.ToolStripStatusLabel tslConsumoMemoria;
    private System.Windows.Forms.Timer tmrMemory;
    private LmCorbieUI.Controls.LmMenuItem menuConfigColunas;
    private LmCorbieUI.Controls.LmMenuItem menuDadosEmpresa;
  }
}