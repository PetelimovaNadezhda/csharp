using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Basket
    {
        public string name;
        Dictionary<int, int> products = new Dictionary<int, int>();

        public Basket(string name)
        {
            this.name = name;
        }

        public void AddProduct(int id)
        {
            if (products.ContainsKey(id))
            {
                int count = products[id];
                products.Remove(id);
                products.Add(id, count);
            }
            products.Add(id, 1);
        }

        public void PrintReceipt()
        {
            Console.WriteLine(this.name + ":");
            double tax = 0;
            double sum = 0;
            foreach (KeyValuePair<int, int> id in products)
            {
                int count = id.Value;
                Products p = Receipt.catalog[id.Key];
                double price = p.price;
                if (p.book == false && p.food == false && p.medical == false)
                {
                    price += Math.Ceiling(p.price * 0.1 * 20.0) / 20.0;
                    tax += Math.Ceiling(p.price * 0.1 * 20.0) / 20.0;
                }
                else price = p.price;
                if (p.imported == true)
                {
                    price += Math.Ceiling(p.price * 0.05 * 20.0) / 20.0;
                    tax += Math.Ceiling(p.price * 0.05 * 20.0) / 20.0;
                }
                sum += price * count;
                //add count for tax
                Console.WriteLine("     " + count + " " + p.name + ": " + String.Format("{0:0.00}", Math.Round(price * count, 2)));
            }
            Console.WriteLine("     " + "Sales Taxes: " + String.Format("{0:0.00}", Math.Round(tax, 2)));
            Console.WriteLine("     " + "Total: " + String.Format("{0:0.00}", Math.Round(sum, 2)));

        }
    }
}
