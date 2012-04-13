using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FeedBackModel
/// </summary>
public class FeedBackModel
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private String _title;

    public String Title
    {
        get { return _title; }
        set { _title = value; }
    }
    private String _description;

    public String Description
    {
        get { return _description; }
        set { _description = value; }
    }
    private DateTime _date;

    public DateTime Date
    {
        get { return _date; }
        set { _date = value; }
    }
    private String _email;

    public String Email
    {
        get { return _email; }
        set { _email = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }
	public FeedBackModel(int id,String title,String description,DateTime date,String email, int status)
	{
        this.Id = id;
        this.Title = title;
        this.Description = description;
        this.Date = date;
        this.Email = email;
        this.Status = status;
	}
    public FeedBackModel()
    {
    }
}