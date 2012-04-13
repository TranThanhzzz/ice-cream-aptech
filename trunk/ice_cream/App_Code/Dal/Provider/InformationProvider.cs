using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for InformationProvider
/// </summary>
public abstract class InformationProvider : DataAccess
{
	public InformationProvider()
	{
        this.ConnectionString = ConfigurationManager.ConnectionStrings["recipeshopConnectionString"].ConnectionString;
	}
    public abstract bool DeleteInformation(int id);
    public abstract bool UpdateInformation(InformationModel model);
    public abstract int InsertInformation(InformationModel model);
    public abstract bool GetByIdInformation(int id);
    public abstract List<InformationModel> GetAllInformation();
}