using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using LmCorbieUI;
using System.Linq;
using System.Windows.Forms;

namespace TGM_DRV {
  internal class DataUltimoArquivoLido {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [DataObjectField(true, false)]
    public int Id { get; set; }
    public DateTime Data { get; set; } = new DateTime(2001, 01, 01);

    public static DataUltimoArquivoLido model = new DataUltimoArquivoLido();

    public static void Salvar() {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          var valPredef = db.DataUltimoArquivoLido.FirstOrDefault();

          if (valPredef == null) {
            model.Id = 1;
            db.DataUltimoArquivoLido.Add(model);
          } else {
            valPredef.Id = model.Id;
            valPredef.Data = model.Data;
          }

          db.SaveChanges();

          MsgBox.Show("Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      } catch (Exception ex) {
        MsgBox.Show("Aconteceu um Erro ao Salvar Configurações Data do Último Arquivo Lido, algumas predefinições de usuário podem não ter sidas salvas.\n" +
            "-------------------------------------\n" +
            "" + ex.Message,
            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static void Carregar() {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          model = db.DataUltimoArquivoLido.FirstOrDefault();

          if (model == null)
            model = new DataUltimoArquivoLido();
        }
      } catch (Exception ex) {
        MsgBox.Show("Aconteceu um Erro ao Retornar Configurações Data do Último Arquivo Lido, algumas predefinições de usuário podem não ter sidas carregadas.\n" +
            "-------------------------------------\n" +
            "" + ex.Message,
            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

  }
}
