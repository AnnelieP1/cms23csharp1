using CimoApp.Mvvm.viewModel;

namespace CimoApp.Mvvm.Views                // Sökvägen till filen
{
    public partial class MainPage : ContentPage
    {
 

        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();       // Hanterar frontend
            BindingContext = viewModel;
        }

    }
}