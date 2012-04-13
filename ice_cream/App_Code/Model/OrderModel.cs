using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderModel
/// </summary>
public class OrderModel
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private int _idUser;

    public int IdUser
    {
        get { return _idUser; }
        set { _idUser = value; }
    }
    private int _idOrderDetail;

    public int IdOrderDetail
    {
        get { return _idOrderDetail; }
        set { _idOrderDetail = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }
	public OrderModel()
	{}
    public OrderModel(int id, int idUser,int idOrderDetail,int status)
    {
        this.Id = id;
        this.IdUser = idUser;
        this.IdOrderDetail = idOrderDetail;
        this.Status = status;
    }
}