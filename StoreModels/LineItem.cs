namespace StoreModels;

public class LineItem
{

    public Product ProductItem { get; set; }
    public int OrderId { get; set; }
    public int InventoryId {get; set;}
    public int ProductId {get; set;}
    public int Quantity { get; set; }

}