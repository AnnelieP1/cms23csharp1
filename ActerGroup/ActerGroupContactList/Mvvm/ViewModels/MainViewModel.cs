using ActerGroupContactList.Mvvm.Models;
using ActerGroupContactList.Mvvm.Views;
using ActerGroupContactList.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActerGroupContactList.Mvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject 
    {

        public MainViewModel()
        {
            UppdateContacts();
            ContactService.ContactsUpdated += UppdateContacts;
        }

        void UppdateContacts()
        {
            
            {
                foreach (var contact in ContactService.GetContacts())
                    Contacts.Add(contact);
            }; 
        }

        [ObservableProperty]
        ObservableCollection<ContactModel> contacts = new ObservableCollection<ContactModel>();

        [RelayCommand]
        async Task GoToAdd()
        {
           await Shell.Current.GoToAsync(nameof(AddPage));
        }
    }
}
