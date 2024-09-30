using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Exercise
{
    public abstract class Book
    {
        private readonly string title;
        private readonly string author;
        protected readonly double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public string GetTitle() => title;

        public string GetAuthor() => author;

        public double GetPrice() => price;

        public abstract double CalculateDiscount();

    }
}
