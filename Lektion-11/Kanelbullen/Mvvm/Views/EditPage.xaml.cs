using Kanelbullen.Mvvm.ViewModels;

namespace Kanelbullen.Mvvm.Views;

public partial class EditPage : ContentPage
{
	public EditPage(EditViewModel editView)
	{
		InitializeComponent();
		BindingContext = editView;
	}
}