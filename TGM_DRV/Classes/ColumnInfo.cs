using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using LmCorbieUI.Design;
using LmCorbieUI;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TGM_DRV {
  internal class ColumnInfo {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [DataObjectField(true, false)]
    public int Id { get; set; }
    public string Name { get; set; }
    public LmValueType Type { get; set; }
    public int LarguraColuna { get; set; }
    public string Display { get; set; }
    public DgvAlignment AlinhamentoColuna { get; set; }
    public Verdade CalcularTotalGrid { get; set; }
    public Verdade GerarGrafico { get; set; }

    public List<ColumnInfo> Columns = new List<ColumnInfo> { };

    public static ColumnInfo model = new ColumnInfo();

    public static void Salvar() {
      using (SQLiteContexto db = new SQLiteContexto())
      using (var transaction = db.Database.BeginTransaction()) {
        try {
          for (int i = 1; i <= 30; i++) {
            var nm = "Coluna" + i;
            var cln = db.ColumnInfo.FirstOrDefault(x => x.Name == nm);
            var md = model.Columns[i];

            cln.Display = md.Display;
            cln.Type = md.Type;
            cln.LarguraColuna = md.LarguraColuna;
            cln.AlinhamentoColuna = md.AlinhamentoColuna;
            cln.CalcularTotalGrid = md.CalcularTotalGrid;
            cln.GerarGrafico = md.GerarGrafico;
          }

          db.SaveChanges();
          transaction.Commit();

          MsgBox.Show("Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } catch (Exception ex) {
          transaction.Rollback();
          MsgBox.Show("Aconteceu um Erro ao Salvar Colunas.\n" +
              "-------------------------------------\n" +
              ex.Message,
              "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }
    }

    public static void Carregar() {
      using (SQLiteContexto db = new SQLiteContexto())
      using (var transaction = db.Database.BeginTransaction()) {
        try {
          model.Columns = db.ColumnInfo.ToList();

          //if (model.Columns.Count() == 0) {
          for (int i = 0; i <= 30; i++) {
            var columName = i == 0 ? "Data" : "Coluna" + i;
            
            if(db.ColumnInfo.Any(x => x.Name == columName)) 
              continue;

            var colInfo = new ColumnInfo {
              Name = columName,
              Display = i == 0 ? "DATA" : "",
              Type = i == 0 ? LmValueType.Data : LmValueType.Alfanumerico,
              LarguraColuna = 100,
              AlinhamentoColuna = i == 0 ? DgvAlignment.Centro : DgvAlignment.Esquerda,
              CalcularTotalGrid = Verdade.Nao,
              GerarGrafico = Verdade.Nao,
            };
            db.ColumnInfo.Add(colInfo);
            db.SaveChanges();
            model.Columns.Add(colInfo);
          }
          transaction.Commit();
          //}
        } catch (Exception ex) {
          transaction.Rollback();
          //MsgBox.Show("Aconteceu um Erro ao Colunas, algumas predefinições de usuário podem não ter sidas carregadas.\n" +
          //    "-------------------------------------\n" +
          //    "" + ex.Message,
          //    "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

      }
    }

  }
}
