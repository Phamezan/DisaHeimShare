using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {

        public string Title { get; set; }
        public double Price { get; set; }


        public Book (string itemId, string title, double price) 
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }

        public Book(string itemId,string title) : this (itemId, title, 0)
        {
        }
        public Book(string itemId) : this (itemId, "", 0)
        {
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price.ToString(CultureInfo.CreateSpecificCulture("da-DA"))}";
        }

        public override double GetValue()
        {
            double total = 0;
            total += Price;
            return total;
        }
    }
}
