using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Account
/// </summary>
public class Account
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private String _userName;

    public String UserName
    {
        get { return _userName; }
        set { _userName = value; }
    }
    private String _passWord;

    public String PassWord
    {
        get { return _passWord; }
        set { _passWord = value; }
    }
    private String _firstName;

    public String FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    private String _lastName;

    public String LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    private String _phone;

    public String Phone
    {
        get { return _phone; }
        set { _phone = value; }
    }
    private String _email;

    public String Email
    {
        get { return _email; }
        set { _email = value; }
    }
    private String _address;

    public String Address
    {
        get { return _address; }
        set { _address = value; }
    }
    private String _accountNumber;

    public String AccountNumber
    {
        get { return _accountNumber; }
        set { _accountNumber = value; }
    }
    private int _idRole;

    public int IdRole
    {
        get { return _idRole; }
        set { _idRole = value; }
    }
    private int _status;

    public int Status
    {
        get { return _status; }
        set { _status = value; }
    }
    private int _idPayment;

    public int IdPayment
    {
        get { return _idPayment; }
        set { _idPayment = value; }
    }

	public Account(int id,String userName,String password,String firstName,String lastName, String email,String accountNumber,String address,int idRole,int status,int idPayment)
	{
        this.Id = id;
        this.UserName = userName;
        this.PassWord = password;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.AccountNumber = accountNumber;
        this.Address = address;
        this.IdRole = idRole;
        this.Status = status;
        this.IdPayment = idPayment;
	}
    public Account()
    {

    }
}