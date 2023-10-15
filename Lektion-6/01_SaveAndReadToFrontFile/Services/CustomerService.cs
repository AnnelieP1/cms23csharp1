susing _01_SaveAndReadToFrontFile.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace _01_SaveAndReadToFrontFile.Services;

internal class CustomerService
{
    public List<Customer> _customerList = new List<Customer>();

    public void AddToList(Customer customer) 
    
    { 
      _customerList.Add(customer);
        var json = JsonConvert.SerializeObject(_customerList);
        FileService.SaveToFile(json);
    }


    public void GetCustomers()
    {
        var content = FileService.ReadFromFile();
        if (!string.IsNullOrEmpty(content))
            _customerList = JsonConvert.DeserializeObject<List<Customer>>(content)!;

        foreach(var customer in _customerList)
        {
            Console.WriteLine($"{customer.FirstName} {customer.LastName} <{customer.Email}>");
        }
    }
}
