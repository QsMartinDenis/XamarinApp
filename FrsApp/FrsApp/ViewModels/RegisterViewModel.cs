using System;
using System.Collections.Generic;
using System.Text;
using FrsApp.Models;
using Xamarin.Forms;

namespace FrsApp.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public User UserData = new User();

        public (string, bool) RegisterUserAsync()
        {
            if (Validation())
            {
                DataStore.AddUserAsync(UserData);
                return ("succes", true);
            }
            else
            {
                return ("All fields must be completed", false);
            }
        }

        private bool Validation()
        {
            if (!string.IsNullOrEmpty(UserData.Email) &&
                !string.IsNullOrEmpty(UserData.FirstName) &&
                !string.IsNullOrEmpty(UserData.LastName) &&
                !string.IsNullOrEmpty(UserData.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
