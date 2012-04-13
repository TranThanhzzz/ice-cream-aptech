using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RoleModel
/// </summary>
public class RoleModel
{
    private int _idRole;

    public int IdRole
    {
        get { return _idRole; }
        set { _idRole = value; }
    }
    private int _userRole;

    public int UserRole
    {
        get { return _userRole; }
        set { _userRole = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }
	public RoleModel()
	{
	}
    public RoleModel(int idrole,int userRole,int status)
    {
        this.IdRole = idrole;
        this.UserRole = userRole;
        this.Status = status;
    }
}