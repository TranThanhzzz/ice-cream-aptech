using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FAQProvider
/// </summary>
public abstract class FAQProvider : DataAccess
{
	public FAQProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteFAQ(int id);
    public abstract bool UpdateFAQ(int id);
    public abstract int InsertFAQ(FAQModel model);
    public abstract bool GetByIdFAQ(int id);
    public abstract List<FAQModel> GetAllFAQ();
}