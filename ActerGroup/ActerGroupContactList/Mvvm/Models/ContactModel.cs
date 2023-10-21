using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActerGroupContactList.Mvvm.Models;

public class ContactModel
{
    public string GroupName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public string FullName => $"{FirstName} {LastName}";  

}

public class Address

{
    public string StreetName { get; set; }
    public string StreetNumber { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Fulladdress => $"{StreetName} {StreetNumber} {PostalCode} {City} {Country}";

}
