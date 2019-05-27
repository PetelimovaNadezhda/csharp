using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Receipt
    {
        static public Dictionary<int, Products> catalog;

        public static void AddCatalog()
        {
            catalog = new Dictionary<int, Products>();
            catalog.Add(1, new Products(1, "book", true, false, false, false, 12.49));
            catalog.Add(2, new Products(2, "music CD", false, false, false, false, 14.99));
            catalog.Add(3, new Products(3, "chocolate bar", false, true, false, false, 0.85));
            catalog.Add(4, new Products(4, "imported box of chocolates", false, true, false, true, 10.00));
            catalog.Add(8, new Products(8, "imported box of chocolates", false, true, false, true, 11.25));
            catalog.Add(5, new Products(5, "imported bottle of perfume", false, false, false, true, 47.50));
            catalog.Add(9, new Products(9, "imported bottle of perfume", false, false, false, true, 27.99));
            catalog.Add(6, new Products(6, "bottle of perfume", false, false, false, false, 18.99));
            catalog.Add(7, new Products(7, "packet of headache pills", false, false, true, false, 9.75));
        }

        static void Main()
        {
            AddCatalog();

            Basket shop1 = new Basket("Output 1");
            shop1.AddProduct(1);
            shop1.AddProduct(2);
            shop1.AddProduct(3);

            Basket shop2 = new Basket("Output 2");
            shop2.AddProduct(4);
            shop2.AddProduct(5);

            Basket shop3 = new Basket("Output 2");
            shop3.AddProduct(9);
            shop3.AddProduct(6);
            shop3.AddProduct(7);
            shop3.AddProduct(8);

            shop1.PrintReceipt();
            shop2.PrintReceipt();
            shop3.PrintReceipt();
        }
    }
}
