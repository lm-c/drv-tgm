using LmCorbieUI;
using LmCorbieUI.LmForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGM_DRV {
  public partial class FrmRegistroDetalha : LmSingleForm {
    public FrmRegistroDetalha(DataGridViewRow row) {
      InitializeComponent();

      try {
        var total = ColumnInfo.model.Columns.Where(x => !string.IsNullOrEmpty( x.Display)).Count();
        this.Height = (total * 25) + 90;

        var dif = 25;

        System.Collections.IList list = row.Cells;
        for (int i = 0; i < list.Count; i++) {
          DataGridViewCell cell = (DataGridViewCell)list[i];
          var colName = cell.OwningColumn.Name;
          var cln = ColumnInfo.model.Columns.FirstOrDefault(x => x.Name == colName);

          if (cln == null || string.IsNullOrEmpty(cln.Display))
            continue;

          var header = cell.OwningColumn.HeaderText;
          var value = cln.Type == LmCorbieUI.Design.LmValueType.Data && cell.Value != null 
            ? Convert.ToDateTime( cell.Value).ToShortDateString() 
            : cell.Value?.ToString();
          var num = i + 1;
          var valY = dif * num;

          var lblColuna1 = new LmCorbieUI.Controls.LmLabel {
            FontWeight = LmCorbieUI.Design.LmLabelWeight.Bold,
            Location = new System.Drawing.Point(129, valY),
            Margin = new System.Windows.Forms.Padding(0),
            Name = "lblColuna" + num,
            Size = new System.Drawing.Size(208, 25),
            TabIndex = 0,
            Text = header + ":",
            TextAlign = System.Drawing.ContentAlignment.MiddleRight
          };

          var lblValor1 = new LmCorbieUI.Controls.LmLabel {
            Location = new System.Drawing.Point(337, valY),
            Margin = new System.Windows.Forms.Padding(0),
            Name = "lblValor" + num,
            Size = new System.Drawing.Size(208, 25),
            TabIndex = 1,
            Text = value,
            TextAlign = System.Drawing.ContentAlignment.MiddleLeft
          };


          this.lblPanel.Controls.Add(lblValor1);
          this.lblPanel.Controls.Add(lblColuna1);
        }
      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao Detalhar linha da Tabela.");
      }
    }
  }
}
