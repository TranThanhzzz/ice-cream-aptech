using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ListRecipeModel
{
    private int _id;

    public int Id
    {
      get { return _id; }
      set { _id = value; }
    }
    private int _idCate;

    public int IdCate
    {
      get { return _idCate; }
      set { _idCate = value; }
    }
    private String _title;

    public String Title
    {
      get { return _title; }
      set { _title = value; }
    }
    private String _image;

    public String Image
    {
      get { return _image; }
      set { _image = value; }
    }
    private String _description;

    public String Description
    {
      get { return _description; }
      set { _description = value; }
    }
    private String _detail;

    public String Detail
    {
      get { return _detail; }
      set { _detail = value; }
    }
      private Double _price;

    public Double Price
    {
      get { return _price; }
      set { _price = value; }
    }
    private Double _discount;

    public Double Discount
    {
      get { return _discount; }
      set { _discount = value; }
    }
    private int _status;

    public int Status
    {
      get { return _status; }
      set { _status = value; }
    }

	public ListRecipeModel(){	}

    public ListRecipeModel(int id, int idCate,String title,String image,String description,String detail,Double price,Double discount,int status) 
    {
        this.Id = id;
        this.IdCate = idCate;
        this.Title = title;
        this.Image = image;
        this.Description = description;
        this.Detail = detail;
        this.Price = price;
        this.Discount = discount;
        this.Status = status;
    }
}