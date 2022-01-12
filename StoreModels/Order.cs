namespace StoreModels;
using System.Data;

public class Order
{

    public string OrderDate {get; set;}
    public int StoreId {get; set;}
    public int CustomerId {get; set;}
    public int OrderNumber {get; set;}
    public int InventoryId {get; set;}
    public List<LineItem> LineItems {get; set;}
    public decimal Total {get; set;}

public void ToDataRow(ref DataRow row)
{
    row["Id"] = this.OrderNumber;
    row["CustomerId"] = this.CustomerId;
    row["StoreId"] = this.StoreId;
    row["Total"] = this.Total;
    row["OrderDate"] = this.OrderDate;
}

    // public decimal CalculateTotal() 
    // {
    //     decimal total = 0;
    //     if(this.LineItems?.Count > 0 )
    //     {
    //         foreach(LineItem orderitem in this.LineItems)
    //         {
                
    //             total += orderitem.ProductItem.Price * orderitem.Quantity;
    //         }
    //     }
        
    //     this.Total = total;
    //     return total;
    // }

    // public string ToDate()
    // {
    //     DateTime thisDay = DateTime.Today;
    //     string today = thisDay.ToString("d");
    //     this.OrderDate = today;
    //     return today; 
    // }







}