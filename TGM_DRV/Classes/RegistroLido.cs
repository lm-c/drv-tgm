using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TGM_DRV {
  internal class RegistroLido {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [DataObjectField(true, false)]
    public int Id { get; set; }

    [StringLength(250)]
    [Required]
    public string NomeArquivo { get; set; }

    public int UltimaLinhalida { get; set; }

  }
}
