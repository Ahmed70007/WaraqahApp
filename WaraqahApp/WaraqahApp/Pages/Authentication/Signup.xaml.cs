using System;
using System.IO;
using WaraqahApp.Tables;
using Xamarin.Forms;
using SQLite;

namespace WaraqahApp.Pages.Authentication
{
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserTable>();

            var item = new RegUserTable()
            {
                UserName = EUN.Text,
                Password = EUP.Text,
                Email = EUE.Text
            };

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Registeration Sucessfull", "", "OK", "Cancel");

                if (result)
                    await Navigation.PushModalAsync(new Login());
            });
        }

        protected void GBack(object sender, EventArgs e)
        {
            App.Current.MainPage = new Login();
        }

    }
}