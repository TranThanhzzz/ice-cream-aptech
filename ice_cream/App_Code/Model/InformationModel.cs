using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for InformationModel
/// </summary>
public class InformationModel
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private String _name;

    public String Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private String _description;

    public String Description
    {
        get { return _description; }
        set { _description = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }

	public InformationModel(){}

    public InformationModel(int id,String name,String description,int status) 
    {
        this.Id=id;
        this.Name = name;
        this.Description = description;
        this.Status = status;
    }
}