using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using WaraqahApp.Pages.Authentication;

using WaraqahApp.Pages;
using Xamarin.Forms;

namespace WaraqahApp
{
    public class Splash : ContentPage
    {
        Image splashImage;

        public Splash()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "Waraqah_LoginPage.png",
                WidthRequest = 100,
            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
               AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#fff");
            this.Content = sub;
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1.2, 1200);
            await splashImage.ScaleTo(1.4, 1400, Easing.Linear);
            await splashImage.ScaleTo(1.6, 1600, Easing.Linear);
            await splashImage.ScaleTo(1.6, 1800);
            Application.Current.MainPage = new NavigationPage(new FirstPage());   
        }
    }
}
