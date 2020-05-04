using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaraqahApp.Pages.MenuSections
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuHistory : ContentPage
    {
        public MenuHistory()
        {
            InitializeComponent();
        }

        async void Cancel(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}