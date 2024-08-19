namespace TGM_DRV {
  partial class FrmImportar {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportar));
      this.btnImportar = new LmCorbieUI.Controls.LmButton();
      this.lblInfo = new LmCorbieUI.Controls.LmLabel();
      this.SuspendLayout();
      // 
      // btnImportar
      // 
      this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.Top;
      this.btnImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.btnImportar.BorderColor = System.Drawing.Color.PaleVioletRed;
      this.btnImportar.BorderRadius = 15;
      this.btnImportar.BorderSize = 0;
      this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnImportar.Image = ((System.Drawing.Image)(resources.GetObject("btnImportar.Image")));
      this.btnImportar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnImportar.Location = new System.Drawing.Point(135, 114);
      this.btnImportar.Name = "btnImportar";
      this.btnImportar.Size = new System.Drawing.Size(198, 33);
      this.btnImportar.TabIndex = 5;
      this.btnImportar.Text = "  Iniciar Importação";
      this.btnImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnImportar.UseVisualStyleBackColor = false;
      this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.AutoSize = true;
      this.lblInfo.FontSize = LmCorbieUI.Design.LmLabelSize.Tall;
      this.lblInfo.FontWeight = LmCorbieUI.Design.LmLabelWeight.Bold;
      this.lblInfo.Location = new System.Drawing.Point(108, 66);
      this.lblInfo.Margin = new System.Windows.Forms.Padding(3);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(253, 25);
      this.lblInfo.TabIndex = 6;
      this.lblInfo.Text = "Lendo Dados FTP, Aguarde...";
      this.lblInfo.Visible = false;
      // 
      // FrmImportar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(468, 248);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.btnImportar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(0, 0);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmImportar";
      this.Resizable = false;
      this.Text = "Importar Dados do FTP";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private LmCorbieUI.Controls.LmButton btnImportar;
    private LmCorbieUI.Controls.LmLabel lblInfo;
  }
}