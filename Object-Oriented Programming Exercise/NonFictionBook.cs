using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming_Exercise
{
    public class NonFictionBook : Book
    {
        private readonly string subject;

        public NonFictionBook(string title, string author, double price, string subject)
      : base(title, author, price)
        {
            this.subject = subject;
        }

        public override double CalculateDiscount()
        {
            return price * 0.05;
        }
    }
}
