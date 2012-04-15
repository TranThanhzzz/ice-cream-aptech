using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary> 
/// Summary description for SqlFAQ
/// </summary>
public class SqlFAQ :FAQProvider
{
	public SqlFAQ()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeleteFAQ(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_FAQ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool UpdateFAQ(FAQModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_FAQ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@Id_User", SqlDbType.Int).Value = model.IdUser;
            cmd.Parameters.Add("@Descriotion", SqlDbType.NVarChar).Value = model.Descriotion;
            cmd.Parameters.Add("@Answer", SqlDbType.NVarChar).Value = model.Answer;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;

            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertFAQ(FAQModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_FAQ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@Id_User", SqlDbType.Int).Value = model.IdUser;
            cmd.Parameters.Add("@Descriotion", SqlDbType.NVarChar).Value = model.Descriotion;
            cmd.Parameters.Add("@Answer", SqlDbType.NVarChar).Value = model.Answer;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override FAQModel GetByIdFAQ(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_FAQ_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value =id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                InformationModel model = new InformationModel {
                    (int)reader["id"],
                    (int)reader["IdUser"],
                    reader["Description"].ToString,
                    reader["Answer"].ToString,
                    (int)reader["STATUS"]
                };
             }
            else
                return null;
        }
    }

}