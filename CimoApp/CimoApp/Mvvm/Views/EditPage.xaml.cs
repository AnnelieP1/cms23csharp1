using CimoApp.Mvvm.viewModel;

namespace CimoApp.Mvvm.Views;

public partial class EditPage : ContentPage
{

    public EditPage(EditViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel; 
	}
}