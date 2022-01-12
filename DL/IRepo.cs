using StoreModels;

namespace DL;

public interface IRepo
{

    List<Customer> GetAllCustomers();

    void AddCustomer(Customer customerToAdd);

    //void AddInventory(Inventory inventoryId, Order orderId);

    int IsDuplicate(Customer customerToFind);

    void AddOrder(int CustomerId, Order OrderToAdd);

    void AddLineItem(LineItem Cart, int orderId);

    List<Product>GetAllProduct();




}