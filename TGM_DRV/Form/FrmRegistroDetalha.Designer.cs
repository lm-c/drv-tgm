namespace TGM_DRV {
  partial class FrmRegistroDetalha {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroDetalha));
      this.lblPanel = new LmCorbieUI.Controls.LmPanel();
      this.SuspendLayout();
      // 
      // lblPanel
      // 
      this.lblPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.lblPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(233)))));
      this.lblPanel.IsPanelMenu = false;
      this.lblPanel.Location = new System.Drawing.Point(5, 30);
      this.lblPanel.Name = "lblPanel";
      this.lblPanel.Size = new System.Drawing.Size(675, 95);
      this.lblPanel.TabIndex = 0;
      // 
      // FrmRegistroDetalha
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(685, 130);
      this.Controls.Add(this.lblPanel);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = new System.Drawing.Point(0, 0);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(1280, 720);
      this.MinimizeBox = false;
      this.Name = "FrmRegistroDetalha";
      this.Resizable = false;
      this.Text = "Detalhamento Registro";
      this.ResumeLayout(false);

    }

    #endregion

    private LmCorbieUI.Controls.LmPanel lblPanel;
  }
}