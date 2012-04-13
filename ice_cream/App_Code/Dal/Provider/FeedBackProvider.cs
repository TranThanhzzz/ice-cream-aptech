using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FeedBackProvider
/// </summary>
public abstract class FeedBackProvider : DataAccess
{
    public FeedBackProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteFeedBack(int id);
    public abstract bool UpdateFeedBack(int id);
    public abstract int InsertFeedBack(FeedBackModel model);
    public abstract bool GetByIdFeedBack(int id);
    public abstract List<FeedBackModel> GetAllFeedBack();
}