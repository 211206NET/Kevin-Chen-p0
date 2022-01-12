namespace StoreModels;
using System;

public class Order
{

    public string OrderDate {get; set;}
    public int StoreId {get; set;}
    public int CustomerId {get; set;}
    public int OrderNumber {get; set;}
    public int InventoryId {get; set;}
    public List<LineItem> LineItems {get; set;}
    public decimal Total {get; set;}

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