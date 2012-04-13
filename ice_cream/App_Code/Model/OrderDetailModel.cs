using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderDetailModel
/// </summary>
public class OrderDetailModel
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private int _idRecipe;

    public int IdRecipe
    {
        get { return _idRecipe; }
        set { _idRecipe = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }
	public OrderDetailModel(int id, int idRecipe,int status)
	{
        this.Id = id;
        this.IdRecipe = idRecipe;
        this.Status = status;
	}
    public OrderDetailModel()
    {       
    }
}