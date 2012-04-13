using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserProvider
/// </summary>
public abstract class UserProvider : DataAccess
{
	public UserProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteUser(int id);
    public abstract bool UpdateUser(int id);
    public abstract int InsertUser(Account model);
    public abstract bool GetByIdUser(int id);
    public abstract List<Account> GetAllUser();
}