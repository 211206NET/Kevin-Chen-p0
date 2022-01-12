using StoreModels;

namespace BL;

public interface IBL
{
    // Restaurant SearchRestaurant(string searchString);

    List<Customer> GetAllCustomers();

    void AddCustomer(Customer customerToAdd);

    int IsDuplicate(Customer customerToFind);
    
    int IsEmployee(Customer employeeToFind);

    void AddOrder(int CustomerId, Order OrderToAdd);

    void AddLineItem(LineItem Cart, int orderId);

    List<Product>GetAllProduct();

    //void AddInventory(int inventoryId, Order orderId);

}