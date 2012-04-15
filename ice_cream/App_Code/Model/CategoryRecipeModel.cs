using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoryRecipeModel
/// </summary>
public class CategoryRecipeModel
{
    //declare 
    private int _Id;

    public int Id
    {
        get { return _Id; }
        set { _Id = value; }
    }
    private String _Name;

    public String Name
    {
        get { return _Name; }
        set { _Name = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }
    private String _image;

    public String Image
    {
        get { return _image; }
        set { _image = value; }
    }

    public CategoryRecipeModel() { }

	public CategoryRecipeModel(int id, String name,String image, int status)
	{
        this.Id = id;
        this.Name = name;
        this.Status = status;
        this.Image = Image;
	}
}