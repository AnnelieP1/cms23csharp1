using ActerGroupContactList.Mvvm.Models;
using ActerGroupContactList.Mvvm.ViewModels;

namespace ActerGroupContactList.Mvvm.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel detailsViewModel)
	{
		InitializeComponent();
		BindingContext = detailsViewModel;
	}

    public static object ContactsUpdated { get; private set; }

    public static void UpdateContact(ContactModel contact)
    {
        UpdateContact(contact);
        ContactsUpdated?.Invoke();


    }
}