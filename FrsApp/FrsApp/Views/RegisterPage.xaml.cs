using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FrsApp.ViewModels;

namespace FrsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateAccountPage : ContentPage
    {
        private RegisterViewModel RegisterViewModel = new RegisterViewModel();
        public CreateAccountPage()
        {
            InitializeComponent();
            button.ClickedButton = Button_Clicked;
            MainGrid.BindingContext = RegisterViewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            RegisterViewModel.UserData.FirstName = FirstName.TextEntry;
            RegisterViewModel.UserData.LastName = LastName.TextEntry;
            RegisterViewModel.UserData.Email = EmailAddress.TextEntry;
            RegisterViewModel.UserData.Password = EnterPassword.TextEntry;

            if (RegisterViewModel.RegisterUserAsync().Item2)
            {
                App.Current.MainPage = new LoginPage();
            }
            else
            {
                DisplayAlert("", RegisterViewModel.RegisterUserAsync().Item1, "Ok");
            }
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new LoginPage();
        }
    }
}