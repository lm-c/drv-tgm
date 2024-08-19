using System.ComponentModel;

namespace TGM_DRV {
  public enum DgvAlignment {
    [Description("Esquerda")]
    Esquerda = 16,
    [Description("Centro")]
    Centro = 32,
    [Description("Direita")]
    Direita = 64,
  }
  public enum Verdade {
    [Description("Não")]
    Nao = 0,
    [Description("Sim")]
    Sim = 1,
  }

  public enum TipoGrid {
    Default = 0,
    Registro = 1,
  }
}
