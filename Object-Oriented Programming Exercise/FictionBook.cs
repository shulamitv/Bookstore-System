using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Exercise
{
    public class FictionBook : Book
    {
        private readonly string genre;

        public FictionBook(string title, string author, double price, string genre)
        : base(title, author, price)
        {
            this.genre = genre;
        }

        public override double CalculateDiscount()
        {
            return price * 0.10;
        }
    }
}
