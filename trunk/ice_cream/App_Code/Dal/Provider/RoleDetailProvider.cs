using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RoleDetailProvider
/// </summary>
public abstract class RoleDetailProvider : DataAccess
{
    public  RoleDetailProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteRoleDetail(int id);
    public abstract bool UpdateRoleDetail(int id);
    public abstract int InsertRoleDetail(RoleDetailModel model);
    public abstract bool GetByIdRoleDetail(int id);
    public abstract List<RoleDetailModel> GetAllRoleDetail();
}