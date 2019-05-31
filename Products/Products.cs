using System;

namespace Products1
{
    public class Products : IProduct{

        public bool book;
        public bool food;
        public bool medical;
        public bool imported;
        public double price;
        public int count;
        public string name;

        public Products(string name, bool book, bool food, bool medical, bool imported, double price, int count)
        {
            this.name = name;
            this.book = book;
            this.food = food;
            this.medical = medical;
            this.imported = imported;
            this.price = price;
            this.count = count;
        }

        string IProduct.name { get { return name; } set { name = value; } }
        double IProduct.price { get { return price; } set { price = value; } }
        int IProduct.count { get { return count; } set { count = value; } }
    }
}

