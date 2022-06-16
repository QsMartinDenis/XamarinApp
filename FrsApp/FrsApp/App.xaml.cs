﻿using FrsApp.Services;
using FrsApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<DataStore>();
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
