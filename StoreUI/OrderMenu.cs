using BL;
using StoreModels;
using System.Linq;
namespace StoreUI;

public class OrderMenu : IMenu
{

    private IBL _bl;

    public OrderMenu(IBL bl)
    {
        _bl = bl;
    }

    public void Start()
    {   
        if(CurCustomer.cur_customer == null || CurCustomer.cur_customer.Id == 0 )
        {
            Console.WriteLine("please login first!");
            return;
        }
        if(CurCustomer.cur_lineItems == null)
        {
            CurCustomer.cur_lineItems = new List<LineItem>();
        }
        Order newOrder = new Order();
        LineItem AddtoCart = new LineItem();
        bool exit1 = false;
        
        bool exit2 = false;
        Random rand = new Random();
        int randOrderId = rand.Next(1, 50);
        DateTime t = DateTime.Now;
        string today = t.ToString("dd/MM/yyyy");
        
        while(!exit1)
        {
            Console.WriteLine("Welcometo the order menu of the CANDY store\n");
            //Console.WriteLine("What would you like to do?\nview product and place an order [1]\nview your cart [2]\ncheckout and exit [3]");
            Console.WriteLine("What would you like to do?\nview product and place an order [1]\nexit back to main menu [2]");
            string? input = Console.ReadLine();


        
            switch(input)
            {
                case"1":
                while(!exit2)
                {

                    Console.WriteLine("Welcome to the store! \n Please select the following products by number");
                    
                    // Storefront store = CurCustomer.cur_store;
                    Storefront store = new Storefront();
                    // Console.WriteLine(store.StoreId);
                    int storeID = store.StoreId;
                    List<Product> allProduct = _bl.GetAllProduct();
                    for(int i =0; i< allProduct.Count; i++)
                    {
                        Console.WriteLine($"[{i}] {allProduct[i].ProductName}: \n {allProduct[i].Description}: \n Price: {allProduct[i].Price}");
                    }
                    int input1 = int.Parse(Console.ReadLine());
                    Product selectp = new Product();
                    selectp.ProductName = allProduct[input1].ProductName;
                    
                    Console.WriteLine($"How much of the would you like to buy of {selectp.ProductName}");
                    
                    int input2 = int.Parse(Console.ReadLine());
                    int product1 = selectp.ProductId;

                    AddtoCart.ProductItem = selectp;
                    AddtoCart.Quantity = input2;
                    AddtoCart.ProductId = product1;
                    AddtoCart.OrderId = randOrderId;
                    
                    CurCustomer.cur_lineItems.Add(AddtoCart);
                    
                    decimal total = CurCustomer.CalculateTotal();

                    if(CurCustomer.cur_order == null)
                    {
                        newOrder.OrderDate = today;
                        newOrder.OrderNumber = randOrderId;
                        newOrder.StoreId = 1;
                        newOrder.CustomerId = CurCustomer.cur_customer.Id;
                        newOrder.Total = total;

                        CurCustomer.cur_order = newOrder;

                    }
                    else if ( CurCustomer.cur_order != null )
                    {
                        CurCustomer.cur_order.Total = CurCustomer.cur_order.Total + total;
                    }
                    else
                    {}
                    
                    Console.WriteLine($"Your total {CurCustomer.cur_order.Total}");

                    Console.WriteLine("You wish to continue shopping?");
                    Console.WriteLine("[1] to place order\n[2] to continue shopping");

                    string cshop = Console.ReadLine();

                    if( cshop == "1")
                    {
                        _bl.AddOrder(CurCustomer.cur_customer.Id, CurCustomer.cur_order);
                        foreach( LineItem items in CurCustomer.cur_lineItems)
                        {
                            _bl.AddLineItem(items, randOrderId);
                            System.Console.WriteLine("Thank you for placing your order!");
                            Order clearOrder = new Order();
                            CurCustomer.cur_order = clearOrder;
                            exit2 = true;
                        }
                    }
                    else if( cshop == "2")
                    {

                    }


                    
                    
                    //Console.WriteLine(total);
                    //Console.WriteLine($"Total: {newOrder.Total}");
                    // Console.WriteLine("Are you finish adding to the shopping cart?");
                    // Console.WriteLine("[1] for YES\n[2] for NO");
                    // string? done = Console.ReadLine();
                    // if( done == "1") 
                    // {
                    //     exit2 = true;
                    // }


                }//while case1:
                break;
                
                case"2":
                Console.WriteLine("Your returning to main menu");
                exit1 = true;
                //foreach(LineItem item in CurCustomer.cur_lineItems)
                // foreach(LineItem item in cur_cart)
                // {
                //     Console.WriteLine($"Name: {item.ProductItem.ProductName} {item.Quantity}");
                // }
                
                break;
                
                // case"3":
                // Console.WriteLine("You in review history not implemented yet");    
                // break;
                
                default:
                    Console.WriteLine("Wrong input");
                    //exit1 = true;
                break;
            }//switch
        
        }//while


        


        



    }//Start
}//OrderMenu