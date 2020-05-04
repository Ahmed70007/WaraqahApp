using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;


namespace WaraqahApp.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        private double scale;

        public double Scale { get => scale; set => SetProperty(ref scale, value); }

        public string ImageSource { get; set; }
    }
}
