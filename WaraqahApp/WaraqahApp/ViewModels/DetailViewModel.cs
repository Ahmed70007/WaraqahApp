using WaraqahApp.Data;
using WaraqahApp.Models;
using System;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using MvvmHelpers;

namespace WaraqahApp.ViewModels
{
    [QueryProperty("Name", "persondetaildata")]
    public class DetailViewModel : BaseViewModel
    {
        private string _namebook;
        private string _author;
        private string _idbook;

        public string Name
        {
            set
            {
                Item name = ItemData.Items.FirstOrDefault(n => n.NameBook == Uri.UnescapeDataString(value));
                if (name != null)
                {
                    NameBook = name.NameBook;
                    Author = name.Author;
                    IDBook = name.IDBook;
                }
            }
        }

        public string NameBook
        {
            get { return _namebook; }
            set { SetProperty(ref _namebook, value); }
        }

        public string Author
        {
            get { return _author; }
            set { SetProperty(ref _author, value); }
        }
        public string IDBook
        {
            get { return _idbook; }
            set { SetProperty(ref _idbook, value); }
        }

        public ICommand BackCommand
        {
            get
            {
                return new Command(() =>
                { Shell.Current.GoToAsync("//CollectionPage"); });
            }
        }
    }
}