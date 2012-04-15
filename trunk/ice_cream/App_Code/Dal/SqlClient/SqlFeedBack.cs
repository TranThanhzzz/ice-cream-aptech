using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SqlFeedBack
/// </summary>
public class SqlFeedBack:FeedBackProvider
{
	public SqlFeedBack()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeleteFeedBack(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_FEEDBACK", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool UpdateFeedBack(FeedBackModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_FEEDBACK", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = model.Title;
            cmd.Parameters.Add("@Descriotion", SqlDbType.NVarChar).Value = model.Description;
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = model.Date;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = model.Email;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertFeedBack(FeedBackModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_FEEDBACK", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = model.Title;
            cmd.Parameters.Add("@Descriotion", SqlDbType.NVarChar).Value = model.Description;
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = model.Date;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = model.Email;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override FeedBackModel GetByIdFeedBack(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_FEEDBACK_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                FeedBackModel model = new FeedBackModel {
                    (int)reader["id"],
                    reader["Title"].ToString,
                    reader["Description"].ToString,
                    reader["Date"].ToString,//ko biet kieu ji 
                    reader["Email"].ToString,
                    (int)reader["STATUS"]
                };
            }
            else
                return null;
        }
    }
}