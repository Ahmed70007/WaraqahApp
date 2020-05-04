using WaraqahApp.Models;
using System.Collections.Generic;

namespace WaraqahApp.Data
{
    public static class ItemData
    {
        public static IList<Item> Items { get; private set; }

        static ItemData()
        {
            Items = new List<Item>();

            Items.Add(new Item
            {
                NameBook = "The story of Art",
                Author = "A",
                IDBook = "01"
            });

            Items.Add(new Item
            {
                NameBook = "The inside story",
                Author = "b",
                IDBook = "02"
            });

            Items.Add(new Item
            {
                NameBook = "Big magic",
                Author = "c",
                IDBook = "03"
            });

            Items.Add(new Item
            {
                NameBook = "Imagine me",
                Author = "d",
                IDBook = "04"
            });

            Items.Add(new Item
            {
                NameBook = "The things we cannot say",
                Author = "f",
                IDBook = "05"
            });

        }
    }
}