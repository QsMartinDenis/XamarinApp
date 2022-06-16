using FrsApp.Models;
using FrsApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace FrsApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public User currentUser = new User();
        public Command RegisterPage;

        private bool _status = false;

        public LoginViewModel()
        {
            RegisterPage = new Command(() => App.Current.MainPage = new CreateAccountPage());
        }

        public bool Value
        {
            get => _status;
            set
            {
                SetProperty(ref _status, value);
            }
        }
        public bool LoginUser()
        {
            var users = DataStore.GetUsersAsync(true).Result;

            foreach (var person in users)
            {
                if (person.Email == currentUser.Email && person.Password == currentUser.Password)
                {
                    return  true;
                }
            }
            return false;
        }
    }
}
