using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderProvider
/// </summary>
public abstract class OrderProvider : DataAccess
{
	public OrderProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteOrder(int id);
    public abstract bool UpdateOrder(int id);
    public abstract int InsertOrder(OrderModel model);
    public abstract bool GetByIdOrder(int id);
    public abstract List<OrderModel> GetAllOrder();
}