using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaraqahApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            var imageButton = new Xamarin.Forms.ImageButton { Source = "XamarinLogo.png", BackgroundColor = Color.GhostWhite};
            imageButton.On<Android>()
                       .SetIsShadowEnabled(true)
                       .SetShadowColor(Color.Gray)
                       .SetShadowOffset(new Size(10, 10))
                       .SetShadowRadius(12);

        }
    }
}