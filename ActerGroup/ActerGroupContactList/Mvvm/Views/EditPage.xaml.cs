using ActerGroupContactList.Mvvm.ViewModels;

namespace ActerGroupContactList.Mvvm.Views;

public partial class EditPage : ContentPage
{
	public EditPage(EditViewModel editViewModel)
	{
		InitializeComponent();
		BindingContext=editViewModel;
	}
}