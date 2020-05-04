using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaraqahApp.Animations;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaraqahApp.Pages.Authentication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Task.Run(async () =>
            {
                await ViewAnimations.FadeAnimY(Logo);
                await ViewAnimations.FadeAnimY(LoginButton);
                await ViewAnimations.FadeAnimY(SignupButton);
            });
        }

        async void Login(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }

        async void Signup(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Signup());
        }
    }
}