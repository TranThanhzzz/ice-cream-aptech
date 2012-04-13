using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderDetailProvider
/// </summary>
public abstract class OrderDetailProvider : DataAccess
{
	public OrderDetailProvider()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public abstract bool DeleteOrderDetail(int id);
    public abstract bool UpdateOrderDetail(int id);
    public abstract int InsertOrderDetail(OrderDetailModel model);
    public abstract bool GetByIdOrderDetail(int id);
    public abstract List<OrderDetailModel> GetAllOrderDetail();
}