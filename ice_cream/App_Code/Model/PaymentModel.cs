using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PaymentModel
/// </summary>
public class PaymentModel
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private String _name;

    public String Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }

	public PaymentModel(){}

    public PaymentModel(int id, String name,int status) {
        this.Id = id;
        this.Name = name;
        this.Status = status;
    }

	


}