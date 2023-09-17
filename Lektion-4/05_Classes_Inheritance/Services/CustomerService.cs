using _05_Classes_Inheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes_Inheritance.Services;

internal class CustomerService
{

    private static List<Customer> customers = new List<Customer>();
    public static void CreatePrivateCustomer()
    { 
        var customer = new PrivateCustomer();
        Console.Write("Ange Förnamn: ");
        customers.Add(customer);

        customer.FirstName = Console.ReadLine() ?? "";
        Console.Write("Ange Efternamn; ");
        customer.LastName = Console.ReadLine() ?? "";
        Console.Write("Ange Emailadress: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.Write("Ange Telefonnummer; ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        customers.Add(customer);
        Console.WriteLine("En ny privatperson har lagts till i listan");
        Console.ReadKey();
    }
    public static void CreateCompanyCustomer()
    { 
        var customer = new CompanyCustomer();
        customers.Add(customer);

        Console.Write("Ange Företagsnamn: ");
        customer.CompanyName = Console.ReadLine() ?? "";
        Console.Write("Ange Emailadress: ");
        customer.Email = Console.ReadLine() ?? "";
        Console.Write("Ange Telefonnummer; ");
        customer.PhoneNumber = Console.ReadLine() ?? "";

        customers.Add(customer);
        Console.WriteLine("En ny företagskund har lagts till i listan");
        Console.ReadKey();
    }

    
}
