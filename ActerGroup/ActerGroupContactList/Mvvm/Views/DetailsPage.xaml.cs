using ActerGroupContactList.Mvvm.ViewModels;

namespace ActerGroupContactList.Mvvm.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel detailsViewModel)
	{
		InitializeComponent();
		BindingContext = detailsViewModel;
	}
}