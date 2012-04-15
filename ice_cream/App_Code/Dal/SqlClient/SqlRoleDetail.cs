using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SqlRoleDetail
/// </summary>
public class SqlRoleDetail:RoleDetailProvider
{
	public SqlRoleDetail()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeleteRoleDetail(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_ROLEDETAIL", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }
    public override bool UpdateRoleDetail(RoleDetailModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_ROLEDETAIL", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID_ROLE", SqlDbType.Int).Value = model.Id;
           // cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@Detail", SqlDbType.NVarChar).Value = model.Detail;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertRoleDetail(RoleDetailModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_ROLEDETAIL", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID_ROLE", SqlDbType.Int).Value = model.Id;
            // cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@Detail", SqlDbType.NVarChar).Value = model.Detail;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override RoleModel GetByIdRole(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_ROLEDETAIL_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                RoleDetailModel model = new RoleDetailModel {
                    (int)reader["Id"],
                   // reader["Name"].ToString,
                    reader["Detail"].ToString,
                    (int)reader["STATUS"]

                          };
            }
            else
                return null;
        }
    }

}