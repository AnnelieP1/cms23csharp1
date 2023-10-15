using CimoApp.Mvvm.viewModel;

namespace CimoApp.Mvvm.Views;

public partial class DetailsPage : ContentPage
{

    public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel; 
	}

    protected override void OnNavigatedTo( args)
    {
        base.OnNavigatedTo(args);

        if (AccelerometerChangedEventArgs.TryGetValue();
    }
}