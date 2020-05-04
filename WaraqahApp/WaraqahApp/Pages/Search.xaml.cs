using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaraqahApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WaraqahApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Search : ContentPage
    {
        public Search()
        {
            BindingContext = new CollectionViewModel();

            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }
    }
}