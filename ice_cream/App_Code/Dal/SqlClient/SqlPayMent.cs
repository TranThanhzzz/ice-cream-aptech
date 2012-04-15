using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SqlPayMent
/// </summary>
public class SqlPayMent:PayMentProvider
{
	public SqlPayMent()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeletePayMent(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_PAYMENT", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }
    public override bool UpdatePayMent(PaymentModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_PAYMENT", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertPayMent(PaymentModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_ORDERDETAIL", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override OrderDetailModel GetByIdPayMent(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_PAYMENT_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                PaymentModel model = new PaymentModel {
                    (int)reader["id"],
                    reader["Name"].ToString,
                    (int)reader["STATUS"]

                          };
            }
            else
                return null;
        }
    }
}