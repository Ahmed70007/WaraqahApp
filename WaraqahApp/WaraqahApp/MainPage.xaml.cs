
using WaraqahApp.BottomBar;
using Xamarin.Forms;

namespace WaraqahApp
{
    public partial class MainPage : BottomBarPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }
    }
}
