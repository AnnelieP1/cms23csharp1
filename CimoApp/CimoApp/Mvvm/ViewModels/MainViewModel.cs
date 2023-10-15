using CimoApp.Mvvm.Models;
using CimoApp.Mvvm.Views;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimoApp.Mvvm.viewModel
{
    public partial class MainViewModel : ObservableObject
    {
        
        public MainViewModel()
        {
            UpdateContacts();
            ContactService.ContactsUpdated += UpdateContacts;
        }
        void UpdateContacts()
        {
            ContactList.Clear();
            foreach (var contact in ContactService.GetContacts())
                ContactList.Add(contact);
         
           
                
        }

        [ObservableProperty]
        ObservableCollection<ContactModel> contactList = new ObservableCollection<ContactModel>();


        [RelayCommand]
        async Task GoToAdd()
        {
           try
            {
                await Shell.Current.GoToAsync(nameof(AddPage));
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }

        [RelayCommand]
        async Task GoToDetails(ContactModel contact)
        {
            try
            {
                var email = contact.Email;
                await Shell.Current.GoToAsync($"{nameof(DetailsPage)}?email={email}");
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
        }
    }

}
