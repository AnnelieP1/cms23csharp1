using ActerGroupContactList.Mvvm.ViewModels;

namespace ActerGroupContactList.Mvvm.Views;

public partial class AddPage : ContentPage
{
	public AddPage(AddViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}