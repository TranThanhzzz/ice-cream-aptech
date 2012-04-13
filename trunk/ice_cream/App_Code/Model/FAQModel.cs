using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FAQModel
/// </summary>
public class FAQModel
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
    private String _descriotion;

    public String Descriotion
    {
        get { return _descriotion; }
        set { _descriotion = value; }
    }
    private String _answer;

    public String Answer
    {
        get { return _answer; }
        set { _answer = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }
	public FAQModel(){}
    public FAQModel(int id, int idUser,String description,String answer,int status)
    {
        this.Id = id;
        this.IdUser = idUser;
        this.Descriotion = description;
        this.Answer = answer;
        this.Status = status;
    }
}