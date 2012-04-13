using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SqlCategoryRecipe
/// </summary>
public class SqlCategoryRecipe : CategoryRecipe
{
	public SqlCategoryRecipe()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public override bool DeleteCategoryRecipe(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_DELETE_CATEGORYRECIPE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override bool UpdateCategoryRecipe(CategoryRecipeModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_UPDATE_CATEGORYRECIPE", cn);
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

    public override bool InsertCategoryRecipe(CategoryRecipeModel model)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_ADD_CATEGORYRECIPE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = model.Name;
            cmd.Parameters.Add("@STATUS", SqlDbType.Int).Value = model.Status;
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = model.Description;
            cn.Open();
            int re = ExecuteNonQuery(cmd);
            return (re == 1);
        }
    }

    public override CategoryRecipeModel GetByIdCategoryRecipe(int id)
    {
        using (SqlConnection cn = new SqlConnection(this.ConnectionString))
        {
            SqlCommand cmd = new SqlCommand("proc_GET_CATEGORYRECIPE_BY_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cn.Open();
            IDataReader reader = ExecuteReader(cmd, CommandBehavior.SingleRow);
            if (reader.Read())
            {
                CategoryRecipeModel model = new CategoryRecipeModel {
                    (int)reader["id"],
                    reader["name"].ToString,
                    reader["image"].ToString,
                    (int)reader["STATUS"]
                };
                return model;
            }
            else
                return null;
        }
    }
}