using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaraqahApp.Pages.MenuSections;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaraqahApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        async void Art(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuArt());
        }

        async void Busines(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuBusines());
        }

        async void Travel(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuTravel());
        }

        async void Classic(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuClassic());
        }

        async void Fantasy(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuFantasy());
        }

        async void History(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuHistory());
        }

        async void Sports(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuSports());
        }

    }
}