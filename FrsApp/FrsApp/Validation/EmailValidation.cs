using FrsApp.Controls;
using FrsApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FrsApp.Validation
{
    public class EmailValidation : Behavior<CustomEntry>
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
        private void OnEntryTextChanged(CustomEntry sender, TextChangedEventArgs e)
        {
            sender.TextEntry = e.NewTextValue;
            string email = e.NewTextValue;

            if (IsValidEmail(email))
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
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return IsValid = addr.Address == email;
            }
            catch
            {
                return IsValid = false;
            }
        }
    }
}
