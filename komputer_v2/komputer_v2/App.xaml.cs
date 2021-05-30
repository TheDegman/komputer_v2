using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace komputer_v2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new amdFlyout("", "", "", "", "", "","","",""));
            //MainPage = new NavigationPage(new MainPage("dorianmarusic@gmail.com","lozinka"));
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
