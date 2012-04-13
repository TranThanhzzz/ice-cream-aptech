using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserRolePRovider
/// </summary>
public abstract class UserRolePRovider : DataAccess
{
	public UserRolePRovider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteUserRole(int id);
    public abstract bool UpdateUserRole(int id);
    public abstract int InsertUserRole(UserRole model);
    public abstract bool GetByIdUserRole(int id);
    public abstract List<UserRole> GetAllUserRole();
}