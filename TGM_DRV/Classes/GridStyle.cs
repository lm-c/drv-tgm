using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGM_DRV {
  internal class GridStyle {
    #region Propriedades

    public int UsuarioID { get; set; } = 0;
    public TipoGrid TipoGrid { get; set; } = TipoGrid.Default;
    public string PosicaoColuna { get; set; } = "";
    public string OrdemColuna { get; set; } = "";
    public string ColunaOculta { get; set; } = "";
    public string ColunaOcultaImpressao { get; set; } = "";
    public string ColunaFixa { get; set; } = "";

    #endregion

    #region Metodos

    //public static GridStyle Get(TipoGrid tipoGrid) {
    //  GridStyle _return = new GridStyle {
    //    TipoGrid = tipoGrid,
    //    UsuarioID = InfoDefault.UsuarioLogado_ID
    //  };

    //  var conn = ConexaoMySql_Config.GetConexao();

    //  try {
    //    conn.Open();

    //    using (MySqlCommand cmd = new MySqlCommand()) {
    //      cmd.Connection = conn;
    //      cmd.CommandText = "SELECT * FROM Grid WHERE UsuarioID=@UsuarioID && TipoGrid=@TipoGrid";

    //      cmd.Parameters.AddWithValue("@UsuarioID", InfoDefault.UsuarioLogado_ID);
    //      cmd.Parameters.AddWithValue("@TipoGrid", (int)tipoGrid);

    //      using (MySqlDataReader dr = cmd.ExecuteReader()) {
    //        if (dr.HasRows) {
    //          dr.Read();
    //          _return.PosicaoColuna = !dr.IsDBNull(dr.GetOrdinal("PosicaoColuna")) ? dr.GetString(dr.GetOrdinal("PosicaoColuna")) : "";
    //          _return.OrdemColuna = !dr.IsDBNull(dr.GetOrdinal("OrdemColuna")) ? dr.GetString(dr.GetOrdinal("OrdemColuna")) : "";
    //          _return.ColunaOculta = !dr.IsDBNull(dr.GetOrdinal("ColunaOculta")) ? dr.GetString(dr.GetOrdinal("ColunaOculta")) : "";
    //          _return.ColunaOcultaImpressao = !dr.IsDBNull(dr.GetOrdinal("ColunaOcultaImpressao")) ? dr.GetString(dr.GetOrdinal("ColunaOcultaImpressao")) : "";
    //          _return.ColunaFixa = !dr.IsDBNull(dr.GetOrdinal("ColunaFixa")) ? dr.GetString(dr.GetOrdinal("ColunaFixa")) : "";
    //        }
    //      }
    //    }

    //    conn.Close();
    //  } catch (Exception ex) {
    //    //throw ex;
    //  }

    //  return _return;
    //}

    //public static void SetOrUpdate(GridStyle model) {
    //  var conn = ConexaoMySql_Config.GetConexao();

    //  try {
    //    conn.Open();

    //    using (MySqlCommand cmd = new MySqlCommand()) {
    //      cmd.Connection = conn;
    //      cmd.CommandText = "SELECT COUNT(*) FROM Grid WHERE UsuarioID=@UsuarioID && TipoGrid=@TipoGrid";
    //      cmd.Parameters.AddWithValue("@UsuarioID", InfoDefault.UsuarioLogado_ID);
    //      cmd.Parameters.AddWithValue("@TipoGrid", (int)model.TipoGrid);

    //      var cont = Convert.ToInt32(cmd.ExecuteScalar());

    //      if (cont == 0) {
    //        cmd.Connection = conn;
    //        cmd.CommandText =
    //            "INSERT INTO Grid " +
    //            "(UsuarioID,TipoGrid,PosicaoColuna,OrdemColuna,ColunaOculta,ColunaOcultaImpressao,ColunaFixa) " +
    //            "VALUES " +
    //            "(@UsuarioID,@TipoGrid,@PosicaoColuna,@OrdemColuna,@ColunaOculta,@ColunaOcultaImpressao,@ColunaFixa)";

    //        cmd.Parameters.AddWithValue("@PosicaoColuna", model.PosicaoColuna);
    //        cmd.Parameters.AddWithValue("@OrdemColuna", model.OrdemColuna);
    //        cmd.Parameters.AddWithValue("@ColunaOculta", model.ColunaOculta);
    //        cmd.Parameters.AddWithValue("@ColunaOcultaImpressao", model.ColunaOcultaImpressao);
    //        cmd.Parameters.AddWithValue("@ColunaFixa", model.ColunaFixa);

    //        var x = cmd.ExecuteNonQuery();
    //      } else {
    //        cmd.Connection = conn;
    //        cmd.CommandText =
    //            "UPDATE Grid " +
    //            "SET " +
    //            "UsuarioID=@UsuarioID,TipoGrid=@TipoGrid,PosicaoColuna=@PosicaoColuna,OrdemColuna=@OrdemColuna," +
    //            "ColunaOculta=@ColunaOculta,ColunaOcultaImpressao=@ColunaOcultaImpressao,ColunaFixa=@ColunaFixa " +
    //            "WHERE UsuarioID=@UsuarioID && TipoGrid=@TipoGrid";

    //        cmd.Parameters.AddWithValue("@PosicaoColuna", model.PosicaoColuna);
    //        cmd.Parameters.AddWithValue("@OrdemColuna", model.OrdemColuna);
    //        cmd.Parameters.AddWithValue("@ColunaOculta", model.ColunaOculta);
    //        cmd.Parameters.AddWithValue("@ColunaOcultaImpressao", model.ColunaOcultaImpressao);
    //        cmd.Parameters.AddWithValue("@ColunaFixa", model.ColunaFixa);

    //        var x = cmd.ExecuteNonQuery();
    //      }


    //    }

    //    conn.Close();
    //  } catch (Exception ex) {
    //    //throw ex;
    //  }

    //}

    #endregion
  }
}
