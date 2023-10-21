using ActerGroupContactList.Mvvm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActerGroupContactList.Services
{
    public class ContactService
    {
        private static List<ContactModel> Contacts = new List<ContactModel>();
        public static event Action ContactsUpdated;

        public static void AddToList(ContactModel contact)
        {
            Contacts.Add(contact);
            ContactsUpdated.Invoke();
        }

        public static List<ContactModel> GetContacts()
        {
            return Contacts;
        }

        public static void SaveToList(ContactModel contact)
        {
            SaveToList(contact);

        }

        public static void GetAllContacts(ContactModel contact)
        {
            GetAllContacts(contact);
        }

        public static void GetOneContact(ContactModel contact)
        {
            GetOneContact(contact);
        }

        public static void RemoveOneContact(ContactModel contact)
        {
            RemoveOneContact(contact);
        }

        public static void UpdateContact(ContactModel contact)
        {
            UpdateContact(contact);
            ContactsUpdated?.Invoke();


        }

    }

}
