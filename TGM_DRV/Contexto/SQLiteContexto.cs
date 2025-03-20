using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace TGM_DRV {
  internal class SQLiteContexto : DbContext {
    public SQLiteContexto() : base(ConexaoSQLite.GetConexao(), true) {
      //Database.Connection.ConnectionString = ConexaoSQLite.ConnectionString;
    }

    public DbSet<DataUltimoArquivoLido> DataUltimoArquivoLido { get; set; }
    public DbSet<Empresa> Empresa { get; set; }
    public DbSet<FTP> FTP { get; set; }
    public DbSet<Registro> Registro { get; set; }
    public DbSet<RegistroLido> RegistroLido { get; set; }
    public DbSet<ValorPredefinido> ValorPredefinido { get; set; }
    public DbSet<ColumnInfo> ColumnInfo { get; set; }
    public DbSet<GridStyle> GridStyle { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Conventions
          .Remove<PluralizingTableNameConvention>();
      base.OnModelCreating(modelBuilder);
    }
  }
}
