using FrsApp.Controls;
using FrsApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FrsApp.Validation
{
    public class PasswordValidation : Behavior<CustomEntry>
    {
        public static bool IsValid = false;
        protected override void OnAttachedTo(CustomEntry entry)
        {
            entry.Object += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }
        protected override void OnDetachingFrom(CustomEntry entry)
        {
            entry.Object -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }
        private void OnEntryTextChanged(CustomEntry sender, TextChangedEventArgs args)
        {
            sender.TextEntry = args.NewTextValue;
            char[] password = args.NewTextValue.ToCharArray();

            if (IsValidPassword(password))
            {
                sender.TextColorEntry = Color.Black;
                sender.IsVisibleLabelEntry = false;
            }
            else
            {
                sender.TextColorEntry = Color.Red;
                sender.IsVisibleLabelEntry = true;
            }
            LoginPage.UppdateStatusButton();
        }
        private bool IsValidPassword(char[] password)
        {
            char[] special = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };
            int validation = 0;
            int passwordMinLength = 8;

            if (password.Length >= passwordMinLength)
            {
                foreach (char c in password)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        validation++;
                        break;
                    }
                }
                foreach (char c in password)
                {
                    if (c >= 'A' && c <= 'Z')
                    {
                        validation++;
                        break;
                    }
                }
                foreach (char c in password)
                {
                    if (c >= '0' && c <= '9')
                    {
                        validation++;
                        break;
                    }
                }
                string temp = new string(password);

                if (temp.IndexOfAny(special) != -1)
                {
                    validation++;
                }
            }
            return IsValid = (validation == 4);
        }
    }
}
