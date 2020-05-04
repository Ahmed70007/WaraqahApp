using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WaraqahApp.Pages;
using WaraqahApp.Pages.Authentication;

namespace WaraqahApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Splash();
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
