using System;
using System.Data.SQLite;

namespace TGM_DRV {
  internal class ConexaoSQLite {
    public static readonly string LocalDataBase = @"C:\LM Projetos Data\TGM Data Report Viewer\db\";
    public static readonly string Database = LocalDataBase + "base_dados.db";

    public static SQLiteConnection GetConexao() {
      return new SQLiteConnection() {
        ConnectionString = new SQLiteConnectionStringBuilder() { DataSource = Database, ForeignKeys = true }.ConnectionString
      };
    }

    public static string ConnectionString { get; } = @"Data Source=" + Database + ";";

    public void Dispose() {
      GC.Collect();
    }
  }
}
