using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SqlInformation
/// </summary>
public class SqlInformation : InformationProvider
{
	public SqlInformation()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeleteInformation(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_INFORMATION", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool UpdateInformation(InformationModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_INFORMATION", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = model.Description;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertInformation(InformationModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_INFORMATION", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = model.Description;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override InformationModel GetByIdInformation(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("tbh_Articles_GetArticleByID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ArticleID", SqlDbType.Int).Value = articleID;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                InformationModel model = new InformationModel {
                    (int)reader["id"],
                    reader["name"].ToString,
                    reader["Description"].ToString,
                    (int)reader["STATUS"]
                };
                return model;
            }
            else
                return null;
        }
    }

}