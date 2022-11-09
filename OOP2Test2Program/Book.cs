using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Test2Program
{
    internal class Book
    {
        private string title;
        private string author;
        private int year;

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }



        public string Burn()
        {
            return author;
        }
    }

}
