using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;

namespace TGM_DRV {
  internal class GridStyle {
    #region Propriedades

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [DataObjectField(true, false)]
    public int ID { get; set; } = 1;
    public TipoGrid TipoGrid { get; set; } = TipoGrid.Default;
    public string PosicaoColuna { get; set; } = "";
    public string OrdemColuna { get; set; } = "";
    public string ColunaOculta { get; set; } = "";
    public string ColunaOcultaImpressao { get; set; } = "";
    public string ColunaFixa { get; set; } = "";

    #endregion

    #region Metodos

    public static GridStyle Get(TipoGrid tipoGrid) {
      GridStyle _return = new GridStyle {
        TipoGrid = tipoGrid,
      };

      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          var gridStyle = db.GridStyle.Where(x => x.TipoGrid == tipoGrid).FirstOrDefault();

          if (gridStyle != null) {
            _return.PosicaoColuna = gridStyle.PosicaoColuna;
            _return.OrdemColuna = gridStyle.OrdemColuna;
            _return.ColunaOculta = gridStyle.ColunaOculta;
            _return.ColunaOcultaImpressao = gridStyle.ColunaOcultaImpressao;
            _return.ColunaFixa = gridStyle.ColunaFixa;
          }
        }

      } catch (Exception ex) {
        //throw ex;
      }

      return _return;
    }

    public static void SetOrUpdate(GridStyle model) {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {

          var gridStyle = db.GridStyle.Where(x => x.TipoGrid == model.TipoGrid).FirstOrDefault();

          if (gridStyle == null) {
            db.GridStyle.Add(model);
          } else {
            gridStyle.PosicaoColuna = model.PosicaoColuna;
            gridStyle.OrdemColuna = model.OrdemColuna;
            gridStyle.ColunaOculta = model.ColunaOculta;
            gridStyle.ColunaOcultaImpressao = model.ColunaOcultaImpressao;
            gridStyle.ColunaFixa = model.ColunaFixa;
          }

          db.SaveChanges();
        }
      } catch (Exception ex) {
        //throw ex;
      }

    }

    #endregion
  }
}
