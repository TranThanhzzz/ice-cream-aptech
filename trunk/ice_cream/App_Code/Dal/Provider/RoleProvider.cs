using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Role
/// </summary>
public abstract class RoleProvider : DataAccess
{
	public RoleProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteInformation(int id);
    public abstract bool UpdateInformation(int id);
    public abstract int InsertInformation(InformationModel model);
    public abstract bool GetByIdInformation(int id);
    public abstract List<InformationModel> GetAllInformation();
}