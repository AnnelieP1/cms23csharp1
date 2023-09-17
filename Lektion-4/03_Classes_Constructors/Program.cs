using _03_Classes_Constructors.Models;

var customer_1 = new Customer();

var customer_2 = new Customer();
customer_2.Id = 2;
customer_2.Name = "Annelie Pettersson";
customer_2.Email = "gydano1@hotmail.com";
customer_2.PhoneNumber = "1234567890";


var customer_3 = new Customer()
{
    Id = 3,
    Name = "Annelie Pettersson",
    Email = "gydano1@hotmail.com",
    PhoneNumber = "1234567890",
};

var customer_4 = new Customer("Annelie Pettersson", "gydano1@hotmail.com", "1234567890");

