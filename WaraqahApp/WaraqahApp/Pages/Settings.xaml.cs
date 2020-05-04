using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaraqahApp.Pages;
using WaraqahApp.Pages.Authentication;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace WaraqahApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        public Settings()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        async void Nextbtn1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EditProfile());
        }

        async void Nextbtn2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new YourAddedBooks());
        }

        protected void Logout(object sender, EventArgs e)
        {
            App.Current.MainPage = new FirstPage();
        }
    }
}