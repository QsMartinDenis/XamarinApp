using FrsApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FrsApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomBar : ContentView
    {
        public CustomBar()
        {
            InitializeComponent();
        }

        private void Button_Home(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
        private void Button_Considerations(object sender, EventArgs e)
        {
        }
        private void Button_VideoTutorial(object sender, EventArgs e)
        {
        }
        private void Button_Thanks(object sender, EventArgs e)
        {
        }
        private void Button_Settings(object sender, EventArgs e)
        {
            App.Current.MainPage = new SettingsPage();
        }
    }
}