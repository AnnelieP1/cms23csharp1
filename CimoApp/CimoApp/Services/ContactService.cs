using CimoApp.Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimoApp.Services
{
    public  class ContactService
    {
        private static List<ContactModel> contacts { get; set; } = new List<ContactModel>();
        public static event Action ContactsUpdated;

        public static void AddToList(ContactModel contact)
        {
            contacts.Add(contact);
            ContactsUpdated.Invoke();
        }

        public static List<ContactModel> GetContacts() 
        {
            return contacts;
        }
    }
}
