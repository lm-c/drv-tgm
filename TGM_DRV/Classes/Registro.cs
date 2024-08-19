using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using LmCorbieUI.Metodos;
using System.Collections.Generic;
using System.Linq;
using LmCorbieUI;
using System.Reflection;
using LmCorbieUI.Metodos.AtributosCustomizados;

namespace TGM_DRV {
  internal class Registro {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [DataObjectField(true, false)]
    public int Id { get; set; }
    public DateTime Data { get; set; }

    [StringLength(250)]
    public string Coluna1 { get; set; }

    [StringLength(250)]
    public string Coluna2 { get; set; }

    [StringLength(250)]
    public string Coluna3 { get; set; }

    [StringLength(250)]
    public string Coluna4 { get; set; }

    [StringLength(250)]
    public string Coluna5 { get; set; }

    [StringLength(250)]
    public string Coluna6 { get; set; }

    [StringLength(250)]
    public string Coluna7 { get; set; }

    [StringLength(250)]
    public string Coluna8 { get; set; }

    [StringLength(250)]
    public string Coluna9 { get; set; }

    [StringLength(250)]
    public string Coluna10 { get; set; }

    [StringLength(250)]
    public string Coluna11 { get; set; }

    [StringLength(250)]
    public string Coluna12 { get; set; }

    [StringLength(250)]
    public string Coluna13 { get; set; }

    [StringLength(250)]
    public string Coluna14 { get; set; }

    [StringLength(250)]
    public string Coluna15 { get; set; }

    [StringLength(250)]
    public string Coluna16 { get; set; }

    [StringLength(250)]
    public string Coluna17 { get; set; }

    [StringLength(250)]
    public string Coluna18 { get; set; }

    [StringLength(250)]
    public string Coluna19 { get; set; }

    [StringLength(250)]
    public string Coluna20 { get; set; }

    public static SortableBindingList<W_Registro> Selecionar(DateTime dataIni, DateTime dataFim) {
      List<W_Registro> _return = new List<W_Registro>();

      try {
        dataFim = dataFim.Date.AddHoursAndMinutes("23:59");
        using (SQLiteContexto db = new SQLiteContexto()) {
          var query = Enumerable.ToList(
           from x in db.Registro
            .Where(x => x.Data >= dataIni && x.Data <= dataFim)
            .OrderBy(x => x.Data)
           select new {
             x.Id,
             x.Data,
             x.Coluna1,
             x.Coluna2,
             x.Coluna3,
             x.Coluna4,
             x.Coluna5,
             x.Coluna6,
             x.Coluna7,
             x.Coluna8,
             x.Coluna9,
             x.Coluna10,
             x.Coluna11,
             x.Coluna12,
             x.Coluna13,
             x.Coluna14,
             x.Coluna15,
             x.Coluna16,
             x.Coluna17,
             x.Coluna18,
             x.Coluna19,
           });

          foreach (var item in query) {
            W_Registro w_Registro = new W_Registro {
              Codigo = item.Id,
              Data = item.Data.Date,
              Coluna1 = item.Coluna1 != "0" ? item.Coluna1 : "",
              Coluna2 = item.Coluna2 != "0" ? item.Coluna2 : "",
              Coluna3 = item.Coluna3 != "0" ? item.Coluna3 : "",
              Coluna4 = item.Coluna4 != "0" ? item.Coluna4 : "",
              Coluna5 = item.Coluna5 != "0" ? item.Coluna5 : "",
              Coluna6 = item.Coluna6 != "0" ? item.Coluna6 : "",
              Coluna7 = item.Coluna7 != "0" ? item.Coluna7 : "",
              Coluna8 = item.Coluna8 != "0" ? item.Coluna8 : "",
              Coluna9 = item.Coluna9 != "0" ? item.Coluna9 : "",
              Coluna10 = item.Coluna10 != "0" ? item.Coluna10 : "",
              Coluna11 = item.Coluna11 != "0" ? item.Coluna11 : "",
              Coluna12 = item.Coluna12 != "0" ? item.Coluna12 : "",
              Coluna13 = item.Coluna13 != "0" ? item.Coluna13 : "",
              Coluna14 = item.Coluna14 != "0" ? item.Coluna14 : "",
              Coluna15 = item.Coluna15 != "0" ? item.Coluna15 : "",
              Coluna16 = item.Coluna16 != "0" ? item.Coluna16 : "",
              Coluna17 = item.Coluna17 != "0" ? item.Coluna17 : "",
              Coluna18 = item.Coluna18 != "0" ? item.Coluna18 : "",
              Coluna19 = item.Coluna19 != "0" ? item.Coluna19 : "",
            };

            _return.Add(w_Registro);
          }
        }
      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao Selecionar Lançamentos");
      }

      return new SortableBindingList<W_Registro>(_return);
    }

  }
}
