using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SqlUserRole
/// </summary>
public class SqlUserRole:UserRolePRovider
{
	public SqlUserRole()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeleteUserRole(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_USERROLE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool UpdateUserRole(UserRole model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_USERROLE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = model.Id;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Staus;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertUserRole(UserRole model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_USERROLE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Staus;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override UserRole GetByIdUserRole(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_USERROLE_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                UserRole model = new UserRole {
                    (int)reader["Id"],
                    reader["Name"].ToString,
                    (int)reader["STATUS"]
                    //(int)reader["Payment"]
                };
            }
            else
                return null;
        }
    }

}