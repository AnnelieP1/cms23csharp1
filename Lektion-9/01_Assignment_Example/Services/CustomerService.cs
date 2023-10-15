using _01_Assignment_Example.Interfaces;
using _01_Assignment_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Assignment_Example.Services;
public class CustomerService : ICustomerService
{
    private List<ICustomer> _customers = new List<ICustomer>();
    private readonly string _filePath = @"c:\Code\customers.json";
    public async Task AddCustomerAsync(ICustomer customer)
    {
        _customers.Add(customer);
        await FileService.SaveToFileAsync(_filePath, "");
    }
    public IEnumerable<ICustomer> GetAllCustomers() 
    { 
    return _customers;
    }

    public ICustomer GetOneCustomer(string email)
    {
        return _customers.FirstOrDefault(x => x.Email == email)!;
    }

    public void Removecustomer(string email)
    {
        var customer = GetOneCustomer(email);
        _customers.Remove(customer);
    }
}
