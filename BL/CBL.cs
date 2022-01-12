//using System.Runtime.Serialization;
using CustomExceptions;
using DL;
using StoreModels;



namespace BL;
public class CBL : IBL
{

    private IRepo _dl;

    public CBL(IRepo repo)
    {
        _dl = repo;
    }

    public List<Customer> GetAllCustomers()
    {
        return _dl.GetAllCustomers();
    }


    public void AddCustomer(Customer customerToAdd)
    {

        // if(!_dl.IsDuplicate(customerToAdd))
        // {
            
            _dl.AddCustomer(customerToAdd);
        // }
        // else throw new DuplicateRecordException("A candy story with same name and address [test at the moment]");
    }

    public List<Product>GetAllProduct()
    {
        return _dl.GetAllProduct();
    }

    public int IsDuplicate(Customer customerToFind)
    {
        return _dl.IsDuplicate(customerToFind);

    }

    public void AddOrder(int CustomerId, Order OrderToAdd)
    {
        _dl.AddOrder(CustomerId, OrderToAdd);
    }

    public void AddLineItem(LineItem Cart, int orderId)
    {
        _dl.AddLineItem(Cart, orderId);
    }

}

