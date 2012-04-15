using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SqlOrder
/// </summary>
public class SqlOrder:OrderProvider
{
	public SqlOrder()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeleteOrder(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_ORDER", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool UpdateOrder(OrderModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_ORDER", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@ID_USER", SqlDbType.Int).Value = model.IdUser;
            cmd.Parameters.Add("@Id_ORDER_DETAIL", SqlDbType.Int).Value = model.IdOrderDetail;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertOrder(OrderModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_Order", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@ID_USER", SqlDbType.Int).Value = model.IdUser;
            cmd.Parameters.Add("@Id_ORDER_DETAIL", SqlDbType.Int).Value = model.IdOrderDetail;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override OrderModel GetByIdOrder(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_ORDER_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                OrderModel model = new OrderModel {
                    (int)reader["id"],
                    (int)reader["IdUser"],
                    (int)reader["IdOrderDetail"],
                    (int)reader["STATUS"]
                };
            }
            else
                return null;
        }
    }

}