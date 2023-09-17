using _02_Classes_GettersAndSetters.Models;
using System.Text;

var customer = new customer();

// Set - sätt ett värde

customer.FirstName = "Annelie";
customer.LastName = "Pettersson";

// Get - hämta värdet

var name = customer.FullName;

Console.WriteLine(name);

var user = new User();

user.FirstName = "Annelie";
user.LastName = "Pettersson";
user.Email = "gydano1@hotmail.com";

user.SetSecurePassword("BytMig123!");
var password = Encoding.UTF8.GetString (user.Password);
Console.WriteLine($"Password: {password}");
Console.ReadKey();


