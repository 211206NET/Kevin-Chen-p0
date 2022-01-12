using System.Text.Json;
using StoreModels;

namespace DL;

public class FileRepo : IRepo
{
    // private string filePath = "../DL/Inventory.json";

    public FileRepo()
    {}

    private string filePath = "../DL/Customer.json";

    public List<Customer> GetAllCustomers()
    {
        //string jsonString = File.ReadAllText(filePath);

        //return JsonSerializer.Deserialize<List<Customer>>(jsonString);
        string jsonString = "";
        try
        {
            jsonString = File.ReadAllText(filePath);
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        return JsonSerializer.Deserialize<List<Customer>>(jsonString) ?? new List<Customer>();
    }

    public void AddCustomer(Customer customerToAdd)
    {
        List<Customer> allCustomers = GetAllCustomers();
        allCustomers.Add(customerToAdd);
        
        string jsonString = JsonSerializer.Serialize(allCustomers);
        File.WriteAllText(filePath, jsonString);
    }

    

    public List<Customer> SearchCustomers(string searchTerm)
    {
        throw new NotImplementedException();
    }

    public int IsDuplicate(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void AddOrder(int CustomerId, Order OrderToAdd)
    {
        throw new NotImplementedException();
    }


    // public List<Inventory> GetAllInventory()
    // {
    //     string jsonString = File.ReadAllText(filePath);
    //     return JsonSerializer.Deserialize<List<Inventory>>(jsonString);
    // }

}