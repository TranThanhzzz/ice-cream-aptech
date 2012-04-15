using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SqlListRecipe
/// </summary>
public class SqlListRecipe:ListRecipeProvider
{
	public SqlListRecipe()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public override bool DeleteListRecipe(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("DELETE_LISTRECIPE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }
    public override bool UpdateListRecipe(ListRecipeModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_LISTRECIPE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@Id_Cate", SqlDbType.Int).Value = model.IdCate;            
            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = model.Title;
            cmd.Parameters.Add("@Image", SqlDbType.NVarChar).Value = model.Image;            
            cmd.Parameters.Add("@Descriotion", SqlDbType.NVarChar).Value = model.Description;
            cmd.Parameters.Add("@Detail", SqlDbType.NVarChar).Value = model.Detail;
            cmd.Parameters.Add("@Price", SqlDbType.Float).Value = model.Price;
            cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = model.Discount;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool InsertListRecipe(ListRecipeModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_LISTRECIPE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = model.Id;
            cmd.Parameters.Add("@Id_Cate", SqlDbType.Int).Value = model.IdCate;
            cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = model.Title;
            cmd.Parameters.Add("@Image", SqlDbType.NVarChar).Value = model.Image;
            cmd.Parameters.Add("@Descriotion", SqlDbType.NVarChar).Value = model.Description;
            cmd.Parameters.Add("@Detail", SqlDbType.NVarChar).Value = model.Detail;
            cmd.Parameters.Add("@Price", SqlDbType.Float).Value = model.Price;
            cmd.Parameters.Add("@Discount", SqlDbType.Float).Value = model.Discount;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override ListRecipeModel GetByIdListRecipe(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_LISTRECIPE_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                ListRecipeModel model = new ListRecipeModel {
                    (int)reader["id"],
                    (int)reader["IdCate"],
                    reader["Title"].ToString,
                    reader["Image"].ToString,
                    reader["Description"].ToString,
                    reader["Detail"].ToString, 
                    (float)reader["Price"],
                    (float)reader["Discount"],
                    (int)reader["STATUS"]

                          };
            }
            else
                return null;
        }
    }
}