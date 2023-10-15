
/*Json = JavaScript Objekt Notation
 
"key": "value"

{
"firstName": "Annelie",
"lastName": "Pettersson",
"age": 44,
"isActive": false,
"skills": ["C#", "JS", "Python", "C"],
"relatives":
{"firstName": "Niclas", "lastName": "Pettersson"},
{"firstName": "Yvonne", "lastName": "Pettersson"}

 */

using _01_SaveAndReadToFrontFile.Models;
using _01_SaveAndReadToFrontFile.Services;

var customerService = new CustomerService();
customerService.GetCustomers();

var customer = new Customer
{
    FirstName = "Annelie",
    LastName = "Pettersson",
    Email = "gydano1@hotmail.com"
};


customerService.AddToList(customer);

Console.ReadKey();
