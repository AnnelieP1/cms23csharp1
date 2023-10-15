using CimoApp.Mvvm.Models;
using CimoApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CimoApp.Mvvm.viewModel
{
    public partial class AddViewModel : ObservableObject
    {
        [ObservableProperty]
        ContactModel contact = new ContactModel();

        [RelayCommand]
        async Task Add()
        {
            // Lägga till till en lista
            ContactService.AddToList(Contact);

            Contact = new ContactModel();
            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]

        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");

        }
    }
}
