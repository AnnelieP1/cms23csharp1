using CimoApp.Mvvm.viewModel;

namespace CimoApp.Mvvm.Views;

public partial class AddPage : ContentPage
{
	public AddPage(AddViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}