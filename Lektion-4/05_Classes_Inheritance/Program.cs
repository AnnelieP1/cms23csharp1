using _05_Classes_Inheritance.Models;
using _05_Classes_Inheritance.Services;
/*
var customer = new Customer();
Console.WriteLine(customer.Id);
Console.WriteLine("Created: " + customer.Created);
Console.WriteLine("Modified: " +customer.Modified );
Console.ReadKey();
*/
/*
var privateCustomer = new PrivateCustomer()
{

    // Info hämtad från Customer delen
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,

    //Info hämtad från PrivateCustomer delen

    Email = "gydano1@hotmail.com",
    FirstName = "Annelie",
    LastName = "Pettersson",
    PhoneNumber = "1234567890",


};

var companyCustomer = new CompanyCustomer()

{
    Id = Guid.NewGuid(),
    Created = DateTime.Now,
    Modified = DateTime.Now,
    Email = "gydano1@hotmail.com",
    CompanyName = "Nackademin",
    PhoneNumber = "1234567890",

};
*/
var runAgain = false;
do 

{ 
    Console.WriteLine("Vad för typ av kund vill du skapa (p= privatperson f = företag)");
    var option = Console.ReadLine();

    switch (option?.ToLower())   

    {
    case "p":

        CustomerService.CreatePrivateCustomer();

        break;

    case "f":

        CustomerService.CreateCompanyCustomer();

        break;

        default:
            break;

    }
    Console.Write("Vill du fortsätta: (j/n)");
    runAgain= (Console.ReadLine()!.ToLower() == "j") ? true : false;

}

while (runAgain);
Environment.Exit(0);