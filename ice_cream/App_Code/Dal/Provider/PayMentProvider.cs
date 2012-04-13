using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PayMentProvider
/// </summary>
public abstract class PayMentProvider : DataAccess
{
	public PayMentProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeletePayMent(int id);
    public abstract bool UpdatePayMent(int id);
    public abstract int InsertPayMent(PaymentModel model);
    public abstract bool GetByIdPayMent(int id);
    public abstract List<PaymentModel> GetAllPayMent();
}