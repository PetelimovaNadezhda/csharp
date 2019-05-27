using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Products
    {
        public int id;
        public String name;

        public bool book;
        public bool food;
        public bool medical;
        public bool imported;

        public double price;

        public Products(int id, string name, bool book, bool food, bool medical, bool imported, double price)
        {
            this.id = id;
            this.name = name;
            this.book = book;
            this.food = food;
            this.medical = medical;
            this.imported = imported;
            this.price = price;
        }
    }
}

