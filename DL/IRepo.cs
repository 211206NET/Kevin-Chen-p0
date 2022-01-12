using StoreModels;

namespace DL;

public interface IRepo
{

    List<Customer> GetAllCustomers();

    List<Product>GetAllProduct();
    void AddCustomer(Customer customerToAdd);

    //void AddInventory(Inventory inventoryId, Order orderId);

    int IsDuplicate(Customer customerToFind);

    int IsEmployee(Customer employeeToFind);

    void AddOrder(int CustomerId, Order OrderToAdd);

    void AddLineItem(LineItem Cart, int orderId);




}