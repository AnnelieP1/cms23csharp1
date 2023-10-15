using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Assignment_Example.Interfaces;

namespace _01_Assignment_Example.Models;

public class Customer : ICustomer
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public IAddress? Address { get; set; }

    public string? FullName => $"{FirstName} {LastName}";
}
