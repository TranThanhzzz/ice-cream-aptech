using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoryRecipe
/// </summary>
public abstract class CategoryRecipe : DataAccess
{
	public CategoryRecipe()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteCategoryRecipe(int id);
    public abstract bool UpdateCategoryRecipe(int id);
    public abstract int InsertCategoryRecipe(CategoryRecipeModel model);
    public abstract bool GetByIdCategoryRecipe(int id);
    public abstract List<CategoryRecipeModel> GetAllCategoryRecipe();
}