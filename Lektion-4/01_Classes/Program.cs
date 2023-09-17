
using _01_Classes.Models;
using _01_Classes.Services;

/* 
 Acces Modifiers
__________________________________________________________________________________________________________________________________________

private                 accessbara bara inom scopet ( dvs { } ) som variabeln ligger inom.
public                  accessbar överallt i hela din solution, dvs även mellan olika projekt. 
internal                accesbar överallt i hela ditt projekt, men inte mellan olika projekt. 

 */

// Vi gör en instans av en customerService så vi kan använda den. 

var customerService = new CustomerService();

customerService.GetCustomers();

customerService.CreateCustomer(new Customer { });

