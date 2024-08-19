using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using LmCorbieUI;

namespace TGM_DRV {
  internal class ValorPredefinido {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; } = 0;
    public DockStyle MenuDockStyle { get; set; } = DockStyle.Left;
    public bool MostrarApenasIconeMenu { get; set; } = true;
    public bool MostrarIconePequeno { get; set; } = true;
    [StringLength(20)]
    public string CorPrimaria { get; set; } = "26, 54, 71";
    [StringLength(20)]
    public string CorSecundaria { get; set; } = "245, 248, 252";

    public static ValorPredefinido model = new ValorPredefinido();

    public static void Salvar() {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          var valPredef = db.ValorPredefinido.FirstOrDefault();

          if (valPredef == null) {
            model.Id = 1;
            db.ValorPredefinido.Add(model);
          } else {
            valPredef.Id = model.Id;
            valPredef.MenuDockStyle = model.MenuDockStyle;
            valPredef.MostrarApenasIconeMenu = model.MostrarApenasIconeMenu;
            valPredef.MostrarIconePequeno = model.MostrarIconePequeno;
            valPredef.CorPrimaria = model.CorPrimaria;
            valPredef.CorSecundaria = model.CorSecundaria;
          }

          db.SaveChanges();
        }
      } catch (Exception ex) {
        MsgBox.Show("Aconteceu um Erro ao Salvar Configurações do Sistema, algumas predefinições de usuário podem não ter sidas salvas.\n" +
            "-------------------------------------\n" +
            "" + ex.Message,
            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static void Carregar() {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          model = db.ValorPredefinido.FirstOrDefault();

          if (model == null)
            model = new ValorPredefinido();
          else {
            if (string.IsNullOrEmpty(model.CorPrimaria) || string.IsNullOrEmpty(model.CorSecundaria)) {
              model.CorPrimaria = "13,71,161";
              model.CorSecundaria = "207,232,251";
            }
          }
        }
      } catch (Exception ex) {
        MsgBox.Show("Aconteceu um Erro ao Retornar Configurações do Sistema, algumas predefinições de usuário podem não ter sidas carregadas.\n" +
            "-------------------------------------\n" +
            "" + ex.Message,
            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

  }
}
