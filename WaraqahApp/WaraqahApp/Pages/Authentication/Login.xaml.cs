using System;
using System.Collections.Generic;
using System.IO;
using WaraqahApp.Tables;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaraqahApp.Pages.Authentication;
using WaraqahApp.Pages;
using Xamarin.Forms;
using SQLite;
using Xamarin.Forms.Xaml;

namespace WaraqahApp.Pages.Authentication
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }
        async void Btn1(Object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            var myquery = db.Table<RegUserTable>().Where(u => u.UserName.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text)).FirstOrDefault();

            if (myquery != null)
            {
                App.Current.MainPage = new NavigationPage(new MainPage());
            }

            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Failed Username or Password", "OK", "Cancel");

                    if (result)
                        App.Current.MainPage = new Login();
                    else
                    {
                        App.Current.MainPage = new Login();
                    }
                });
            }
        }
        protected void Btn2(object sender, EventArgs e)
        {
            App.Current.MainPage = new Signup();
        }
    }
}