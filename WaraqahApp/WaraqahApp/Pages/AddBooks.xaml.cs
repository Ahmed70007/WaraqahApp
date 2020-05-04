using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaraqahApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddBooks : ContentPage
    {
        public AddBooks()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }
    }
}