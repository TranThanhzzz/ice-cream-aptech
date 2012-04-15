using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
/// <summary>
/// Summary description for SqlUser
/// </summary>
public class SqlUser:UserProvider
{
	public SqlUser()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeleteUser(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_USER", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool UpdateUser(Account model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_USER", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = model.UserName;
            cmd.Parameters.Add("@PassWord", SqlDbType.NVarChar).Value = model.PassWord;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = model.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = model.LastName;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = model.Phone;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = model.Email;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = model.Address;
            cmd.Parameters.Add("@IdRole", SqlDbType.Int).Value = model.IdRole;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            // cmd.Parameters.Add("@IdPayment", SqlDbType.Int).Value = model.IdPayment;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertUser(Account model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_USER", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = model.UserName;
            cmd.Parameters.Add("@PassWord", SqlDbType.NVarChar).Value = model.PassWord;
            cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = model.FirstName;
            cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = model.LastName;
            cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = model.Phone;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = model.Email;
            cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = model.Address;
            cmd.Parameters.Add("@IdRole", SqlDbType.Int).Value = model.IdRole;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
           // cmd.Parameters.Add("@IdPayment", SqlDbType.Int).Value = model.IdPayment;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override Account GetByIdUser(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_USER_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                Account model = new Account {
                    (int)reader["id"],
                    reader["UserName"].ToString,
                    reader["PassWord"].ToString,
                    reader["FirstName"].ToString, 
                    reader["LastName"].ToString,
                    reader["Phone"].ToString,
                    reader["Email"].ToString,
                    reader["Address"].ToString,
                    (int)reader["IdRole"],
                    (int)reader["STATUS"]
                    //(int)reader["Payment"]
                };
            }
            else
                return null;
        }
    }

}