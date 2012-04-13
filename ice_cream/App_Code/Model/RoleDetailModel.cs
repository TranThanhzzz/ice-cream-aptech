using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RoleDetailModel
/// </summary>
public class RoleDetailModel
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
    private String _detail;

    public String Detail
    {
        get { return _detail; }
        set { _detail = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }
	public RoleDetailModel(int id, String name,String detail,int status)
	{
        this.Id = id;
        this.Name = name;
        this.Detail = detail;
        this.Status = status;
	}
    public RoleDetailModel()
    {

    }
}