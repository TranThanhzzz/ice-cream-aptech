using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserRole
/// </summary>
public class UserRole
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
    private int _staus;

    public int Staus
    {
        get { return _staus; }
        set { _staus = value; }
    }
	public UserRole(int id,String name,int status)
	{
        this.Id = id;
        this.Name = name;
        this.Staus = status;
	}
    public UserRole()
    {

    }
}