using FrsApp.Validation;
using FrsApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private static LoginViewModel loginViewModel = new LoginViewModel();
        public LoginPage()
        {
            InitializeComponent();
            button.ClickedButton = Login;
            link.Command = loginViewModel.RegisterPage;
            MainGrid.BindingContext = loginViewModel;
        }
        public static void UppdateStatusButton()
        {
            loginViewModel.Value = EmailValidation.IsValid && PasswordValidation.IsValid;
        }
        public void Login(object sender, EventArgs e)
        {
            loginViewModel.currentUser.Email = email.TextEntry;
            loginViewModel.currentUser.Password = password.TextEntry;

            if (loginViewModel.LoginUser())
            {
                App.Current.MainPage = new MainPage();
            }
            else
            {
                DisplayAlert("","Incorrect information","Ok");
            }
        }
    }
}