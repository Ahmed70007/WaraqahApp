using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace WaraqahApp.Pages.MenuSections
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuArt : ContentPage
    {
        public MenuArt()
        {
            InitializeComponent();

            var imageButton = new Xamarin.Forms.ImageButton { Source = "XamarinLogo.png", BackgroundColor = Color.GhostWhite };
            imageButton.On<Android>()
                       .SetIsShadowEnabled(true)
                       .SetShadowColor(Color.Gray)
                       .SetShadowOffset(new Size(10, 10))
                       .SetShadowRadius(12);

        }
        async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}