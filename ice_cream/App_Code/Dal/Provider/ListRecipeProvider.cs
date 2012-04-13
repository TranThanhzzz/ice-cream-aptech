using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ListRecipeProvider
/// </summary>
public abstract class ListRecipeProvider : DataAccess
{
	public ListRecipeProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteListRecipe(int id);
    public abstract bool UpdateListRecipe(int id);
    public abstract int InsertListRecipe(ListRecipeModel model);
    public abstract bool GetByIdListRecipe(int id);
    public abstract List<ListRecipeModel> GetAllListRecipe();
}