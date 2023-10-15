using ActerGroupContactList.Mvvm.ViewModels;

namespace ActerGroupContactList.Mvvm.Views
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage(MainViewModel mainViewModel)
        {
            InitializeComponent();
            BindingContext=mainViewModel;

            
        }

      
    }
}