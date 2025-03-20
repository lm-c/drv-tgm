using LmCorbieUI;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TGM_DRV {
  internal class Empresa {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    [DataObjectField(true, false)]
    public int Id { get; set; }

    [StringLength(80)]
    public string RazaoSocial { get; set; }

    [StringLength(9)]
    public string Cep { get; set; }

    [StringLength(50)]
    public string Endereco { get; set; }

    [StringLength(6)]
    public string EnderecoNumero { get; set; }

    [StringLength(50)]
    public string Bairro { get; set; }

    [StringLength(50)]
    public string Cidade { get; set; }

    [StringLength(2)]
    public string Estado { get; set; }

    [StringLength(20)]
    public string Fone { get; set; }

    public string LogoEmpresa { get; set; }

    public static Empresa model = new Empresa();

    public static void Salvar() {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          var empresa = db.Empresa.FirstOrDefault();

          if (empresa == null) {
            model.Id = 1;
            db.Empresa.Add(model);
          } else {
            empresa.Id = model.Id;
            empresa.RazaoSocial = model.RazaoSocial;
            empresa.Cep = model.Cep;
            empresa.Endereco = model.Endereco;
            empresa.EnderecoNumero = model.EnderecoNumero;
            empresa.Bairro = model.Bairro;
            empresa.Cidade = model.Cidade;
            empresa.Estado = model.Estado;
            empresa.Fone = model.Fone;
          }

          db.SaveChanges();

          FrmPrincipal.AtualizarDadosEmpresa();

          MsgBox.Show("Salvo com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      } catch (Exception ex) {
        MsgBox.Show("Aconteceu um Erro ao Salvar dados Empresa.\n" +
            "-------------------------------------\n" +
            "" + ex.Message,
            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    public static void Carregar() {
      try {
        using (SQLiteContexto db = new SQLiteContexto()) {
          model = db.Empresa.FirstOrDefault();

          if (model == null)
            model = new Empresa {
              RazaoSocial = "TGM Máquinas e Equipamentos",
              Cep = "89278-000",
              Endereco = "Rua Progresso",
              EnderecoNumero = "221",
              Bairro = "Distrito Industrial",
              Cidade = "Corupá",
              Estado = "SC",
              Fone = "(47) 3375-2177",
              LogoEmpresa = Properties.Resources.LOGO_TGM_ICONE.ToBase64String(),
            };
        }
      } catch (Exception ex) {
        MsgBox.Show("Aconteceu um Erro ao Retornar Empresa.\n" +
            "-------------------------------------\n" +
            "" + ex.Message,
            "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }
  }
}
