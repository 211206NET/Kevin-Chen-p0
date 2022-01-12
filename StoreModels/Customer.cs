using CustomExceptions;
using System.Text.RegularExpressions;
using System.Data;

namespace StoreModels;


public class Customer
{
    public Customer()
    {}

    public Customer(string username, string password, string city)
    {   
        this.Peoples = new List<string>();
        this.UserName = username;
        this.Password = password;
        this.City =  city;
    }
    public Customer(DataRow row)
    {
        this.Id = (int) row["Id"];
        this.UserName = row["UserName"].ToString() ?? "";
        this.Password = row["Password"].ToString() ?? "";
        // this.City = row["City"].ToString() ?? "";
    }

    public int Id {get; set;}

    public string UserName {get; set;}

    public string Password {get; set;}

    public string City {get; set;}

    public List<string> Peoples {get; set;} // temp list of customers

    //public string Email {get; set;}
    //public List<string> Peoples {get; set;} // temp list of customers
    //public List<Order> Orders {get; set;}


    public override string ToString()
    {
            return $"Username: {this.UserName} Password: {this.Password}";
    }

        public void ToDataRow(ref DataRow row)
    {
        row["UserName"] = this.UserName;
        row["Password"] = this.Password;
        // row["City"] = this.City;
    }
    
}