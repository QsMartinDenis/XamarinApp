using FrsApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FrsApp.ViewModels
{
    public class TestViewModel
    {
        public Command LinkTest { get; }
        public TestViewModel()
        {
            LinkTest = new Command(() => App.Current.MainPage = new MainPage());
        }
    }
}
