using _01_Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Classes.Services;

internal class CustomerService
{

    // service = 90% methods

    // fields 

     // Constructors

    // Properties   

    // fields

    private List<Customer> _customerList;

    // methods (propertyName)
    public void CreateCustomer(Customer customer) 
    { 
    if (!_customerList.Contains(customer))
            _customerList.Add(customer);
    }
    public void GetCustomer() { }
    public List<Customer> GetCustomers() 
    
    { 
    return _customerList.OrderBy(x => x.Id).ToList();
        
    }
    public void UpdateCustomer() { }
    public void DeleteCustomer() { }


 

    
}
