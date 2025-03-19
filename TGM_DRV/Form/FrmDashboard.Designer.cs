namespace TGM_DRV {
  partial class FrmDashboard {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
      this.lmLabel1 = new LmCorbieUI.Controls.LmLabel();
      this.lmLabel2 = new LmCorbieUI.Controls.LmLabel();
      this.txtIni = new LmCorbieUI.Controls.LmTextBox();
      this.txtFim = new LmCorbieUI.Controls.LmTextBox();
      this.btnPesquisar = new LmCorbieUI.Controls.LmButton();
      this.btnLimpar = new LmCorbieUI.Controls.LmButton();
      this.gpbFiltro = new LmCorbieUI.Controls.LmGroupBox();
      this.gpbTabela = new LmCorbieUI.Controls.LmGroupBox();
      this.btnDetalhar = new LmCorbieUI.Controls.LmButton();
      this.dgv = new LmCorbieUI.Controls.LmDataGridView();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.gpbGrafico = new LmCorbieUI.Controls.LmGroupBox();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.pnlGraf2 = new LmCorbieUI.Controls.LmPanel();
      this.pnlGraf1 = new LmCorbieUI.Controls.LmPanel();
      this.gpbFiltro.SuspendLayout();
      this.gpbTabela.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.gpbGrafico.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // lmLabel1
      // 
      this.lmLabel1.AutoSize = true;
      this.lmLabel1.Location = new System.Drawing.Point(11, 29);
      this.lmLabel1.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel1.Name = "lmLabel1";
      this.lmLabel1.Size = new System.Drawing.Size(57, 19);
      this.lmLabel1.TabIndex = 0;
      this.lmLabel1.Text = "Data de";
      // 
      // lmLabel2
      // 
      this.lmLabel2.AutoSize = true;
      this.lmLabel2.Location = new System.Drawing.Point(224, 29);
      this.lmLabel2.Margin = new System.Windows.Forms.Padding(3);
      this.lmLabel2.Name = "lmLabel2";
      this.lmLabel2.Size = new System.Drawing.Size(30, 19);
      this.lmLabel2.TabIndex = 1;
      this.lmLabel2.Text = "Até";
      // 
      // txtIni
      // 
      this.txtIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtIni.BorderRadius = 15;
      this.txtIni.BorderSize = 2;
      this.txtIni.F7ToolTipText = null;
      this.txtIni.F8ToolTipText = null;
      this.txtIni.F9ToolTipText = null;
      this.txtIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtIni.IconF7 = ((System.Drawing.Image)(resources.GetObject("txtIni.IconF7")));
      this.txtIni.IconToolTipText = null;
      this.txtIni.Lines = new string[0];
      this.txtIni.Location = new System.Drawing.Point(75, 23);
      this.txtIni.MaxLength = 32767;
      this.txtIni.Name = "txtIni";
      this.txtIni.PasswordChar = '\0';
      this.txtIni.Propriedade = null;
      this.txtIni.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtIni.SelectedText = "";
      this.txtIni.SelectionLength = 0;
      this.txtIni.SelectionStart = 0;
      this.txtIni.ShortcutsEnabled = true;
      this.txtIni.ShowButtonF7 = true;
      this.txtIni.ShowClearButton = true;
      this.txtIni.Size = new System.Drawing.Size(143, 30);
      this.txtIni.TabIndex = 0;
      this.txtIni.UnderlinedStyle = false;
      this.txtIni.UseSelectable = true;
      this.txtIni.Valor = LmCorbieUI.Design.LmValueType.Data;
      this.txtIni.Valor_Decimais = ((short)(0));
      this.txtIni.WaterMark = "Início";
      this.txtIni.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtIni.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // txtFim
      // 
      this.txtFim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
      this.txtFim.BorderRadius = 15;
      this.txtFim.BorderSize = 2;
      this.txtFim.F7ToolTipText = null;
      this.txtFim.F8ToolTipText = null;
      this.txtFim.F9ToolTipText = null;
      this.txtFim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.txtFim.IconF7 = ((System.Drawing.Image)(resources.GetObject("txtFim.IconF7")));
      this.txtFim.IconToolTipText = null;
      this.txtFim.Lines = new string[0];
      this.txtFim.Location = new System.Drawing.Point(260, 23);
      this.txtFim.MaxLength = 32767;
      this.txtFim.Name = "txtFim";
      this.txtFim.PasswordChar = '\0';
      this.txtFim.Propriedade = null;
      this.txtFim.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtFim.SelectedText = "";
      this.txtFim.SelectionLength = 0;
      this.txtFim.SelectionStart = 0;
      this.txtFim.ShortcutsEnabled = true;
      this.txtFim.ShowButtonF7 = true;
      this.txtFim.ShowClearButton = true;
      this.txtFim.Size = new System.Drawing.Size(143, 30);
      this.txtFim.TabIndex = 1;
      this.txtFim.UnderlinedStyle = false;
      this.txtFim.UseSelectable = true;
      this.txtFim.Valor = LmCorbieUI.Design.LmValueType.Data;
      this.txtFim.Valor_Decimais = ((short)(0));
      this.txtFim.WaterMark = "Fim";
      this.txtFim.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95)))));
      this.txtFim.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnPesquisar.BorderRadius = 15;
      this.btnPesquisar.BorderSize = 0;
      this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
      this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnPesquisar.Location = new System.Drawing.Point(409, 23);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(110, 30);
      this.btnPesquisar.TabIndex = 2;
      this.btnPesquisar.Text = "  Pesquisar";
      this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnPesquisar.UseVisualStyleBackColor = false;
      this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
      // 
      // btnLimpar
      // 
      this.btnLimpar.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnLimpar.BorderRadius = 15;
      this.btnLimpar.BorderSize = 0;
      this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
      this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnLimpar.Location = new System.Drawing.Point(525, 23);
      this.btnLimpar.Name = "btnLimpar";
      this.btnLimpar.Size = new System.Drawing.Size(110, 30);
      this.btnLimpar.TabIndex = 3;
      this.btnLimpar.Text = "  Limpar";
      this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnLimpar.UseVisualStyleBackColor = false;
      this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
      // 
      // gpbFiltro
      // 
      this.gpbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.gpbFiltro, 2);
      this.gpbFiltro.Controls.Add(this.txtIni);
      this.gpbFiltro.Controls.Add(this.btnLimpar);
      this.gpbFiltro.Controls.Add(this.lmLabel1);
      this.gpbFiltro.Controls.Add(this.btnPesquisar);
      this.gpbFiltro.Controls.Add(this.lmLabel2);
      this.gpbFiltro.Controls.Add(this.txtFim);
      this.gpbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
      this.gpbFiltro.Location = new System.Drawing.Point(3, 3);
      this.gpbFiltro.Name = "gpbFiltro";
      this.gpbFiltro.Size = new System.Drawing.Size(890, 65);
      this.gpbFiltro.TabIndex = 0;
      this.gpbFiltro.TabStop = false;
      this.gpbFiltro.Text = "Filtros";
      // 
      // gpbTabela
      // 
      this.gpbTabela.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.gpbTabela, 2);
      this.gpbTabela.Controls.Add(this.btnDetalhar);
      this.gpbTabela.Controls.Add(this.dgv);
      this.gpbTabela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
      this.gpbTabela.Location = new System.Drawing.Point(3, 74);
      this.gpbTabela.Name = "gpbTabela";
      this.gpbTabela.Size = new System.Drawing.Size(890, 206);
      this.gpbTabela.TabIndex = 1;
      this.gpbTabela.TabStop = false;
      this.gpbTabela.Text = "Tabela";
      // 
      // btnDetalhar
      // 
      this.btnDetalhar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnDetalhar.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnDetalhar.BorderRadius = 13;
      this.btnDetalhar.BorderSize = 0;
      this.btnDetalhar.Enabled = false;
      this.btnDetalhar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDetalhar.Image = ((System.Drawing.Image)(resources.GetObject("btnDetalhar.Image")));
      this.btnDetalhar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnDetalhar.Location = new System.Drawing.Point(350, 171);
      this.btnDetalhar.Name = "btnDetalhar";
      this.btnDetalhar.Size = new System.Drawing.Size(120, 26);
      this.btnDetalhar.TabIndex = 5;
      this.btnDetalhar.Text = "  Detalhar";
      this.btnDetalhar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnDetalhar.UseVisualStyleBackColor = false;
      this.btnDetalhar.Click += new System.EventHandler(this.BtnDetalhar_Click);
      // 
      // dgv
      // 
      this.dgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(215)))), ((int)(((byte)(242)))));
      this.dgv.Botao1Largura = 100;
      this.dgv.Botao1Texto = "";
      this.dgv.Botao2Largura = 100;
      this.dgv.Botao2Texto = "";
      this.dgv.ColunaOrdenacaoGrid = "";
      this.dgv.ColunasBloqueadasGrid = "";
      this.dgv.ColunasOcultasGrid = "";
      this.dgv.ColunasOcultasImpressGrid = "";
      this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv.EnabledCsvButton = true;
      this.dgv.EnabledFind = true;
      this.dgv.EnabledHideColumnsButton = false;
      this.dgv.EnabledPdfButton = true;
      this.dgv.EnabledRefreshButton = false;
      this.dgv.LimparSelecaoAposCarregar = false;
      this.dgv.Location = new System.Drawing.Point(3, 20);
      this.dgv.Margin = new System.Windows.Forms.Padding(0);
      this.dgv.MostrarRodapeBotoes = true;
      this.dgv.MostrarTotalizador = true;
      this.dgv.Name = "dgv";
      this.dgv.PermiteAutoDimensionarLinha = false;
      this.dgv.PermiteDimensionarColuna = false;
      this.dgv.PermiteOrdenarColunas = false;
      this.dgv.PermiteOrdenarLinhas = false;
      this.dgv.PermiteQuebrarLinhaCabecalho = false;
      this.dgv.PermiteSelecaoMultipla = false;
      this.dgv.PosColunasGrid = "";
      this.dgv.Size = new System.Drawing.Size(884, 183);
      this.dgv.TabIndex = 0;
      this.dgv.Texto = "";
      this.dgv.TituloRelatorio = "";
      this.dgv.UseSelectable = true;
      this.dgv.ProcurarTextChanged += new LmCorbieUI.Controls.LmDataGridView.TxtChange(this.Dgv_ProcurarTextChanged);
      this.dgv.CellDoubleClick += new LmCorbieUI.Controls.LmDataGridView.CellEvent(this.Dgv_CellDoubleClick);
      this.dgv.RowIndexChanged += new LmCorbieUI.Controls.LmDataGridView.RowEvent(this.Dgv_RowIndexChanged);
      this.dgv.SalvarConfiguracao += new LmCorbieUI.Controls.LmDataGridView.GridEvent(this.Dgv_SalvarConfiguracao);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.gpbGrafico, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.gpbFiltro, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.gpbTabela, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(896, 496);
      this.tableLayoutPanel1.TabIndex = 8;
      // 
      // gpbGrafico
      // 
      this.gpbGrafico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.gpbGrafico, 2);
      this.gpbGrafico.Controls.Add(this.tableLayoutPanel2);
      this.gpbGrafico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(38)))));
      this.gpbGrafico.Location = new System.Drawing.Point(3, 286);
      this.gpbGrafico.Name = "gpbGrafico";
      this.gpbGrafico.Size = new System.Drawing.Size(890, 207);
      this.gpbGrafico.TabIndex = 2;
      this.gpbGrafico.TabStop = false;
      this.gpbGrafico.Text = "Gráfico";
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.pnlGraf2, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.pnlGraf1, 0, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 20);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 184);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // pnlGraf2
      // 
      this.pnlGraf2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlGraf2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
      this.pnlGraf2.IsPanelMenu = false;
      this.pnlGraf2.Location = new System.Drawing.Point(445, 3);
      this.pnlGraf2.Name = "pnlGraf2";
      this.pnlGraf2.Size = new System.Drawing.Size(436, 178);
      this.pnlGraf2.TabIndex = 2;
      // 
      // pnlGraf1
      // 
      this.pnlGraf1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlGraf1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
      this.pnlGraf1.IsPanelMenu = false;
      this.pnlGraf1.Location = new System.Drawing.Point(3, 3);
      this.pnlGraf1.Name = "pnlGraf1";
      this.pnlGraf1.Size = new System.Drawing.Size(436, 178);
      this.pnlGraf1.TabIndex = 1;
      // 
      // FrmDashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(900, 500);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "FrmDashboard";
      this.Padding = new System.Windows.Forms.Padding(2);
      this.Text = "Dashboard";
      this.Loaded += new LmCorbieUI.LmForms.LmChildForm.FormLoad(this.FrmDashboard_Loaded);
      this.gpbFiltro.ResumeLayout(false);
      this.gpbFiltro.PerformLayout();
      this.gpbTabela.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.gpbGrafico.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private LmCorbieUI.Controls.LmLabel lmLabel1;
    private LmCorbieUI.Controls.LmLabel lmLabel2;
    private LmCorbieUI.Controls.LmTextBox txtIni;
    private LmCorbieUI.Controls.LmTextBox txtFim;
    private LmCorbieUI.Controls.LmButton btnPesquisar;
    private LmCorbieUI.Controls.LmButton btnLimpar;
    private LmCorbieUI.Controls.LmGroupBox gpbFiltro;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private LmCorbieUI.Controls.LmGroupBox gpbTabela;
    private LmCorbieUI.Controls.LmGroupBox gpbGrafico;
    private LmCorbieUI.Controls.LmPanel pnlGraf2;
    private LmCorbieUI.Controls.LmPanel pnlGraf1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private LmCorbieUI.Controls.LmDataGridView dgv;
    private LmCorbieUI.Controls.LmButton btnDetalhar;
  }
}

