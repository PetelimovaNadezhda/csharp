using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Basket
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


        public double tax = 0;
        public double sum = 0;
        public void PrintReceipt()
        {
            Console.WriteLine(this.name + ":");
            foreach (KeyValuePair<int, int> id in products)
            {
                int count = id.Value;
                Products p = Receipt.catalog[id.Key];
                double currentTax = Calc.Cost(p) * count;
                tax += currentTax;
                double price = p.price * count + currentTax;
                sum += price;

                Console.WriteLine("     " + count + " " + p.name + ": " + String.Format("{0:0.00}", Math.Round(price, 2)));
            }
            Console.WriteLine("     " + "Sales Taxes: " + String.Format("{0:0.00}", Math.Round(tax, 2)));
            Console.WriteLine("     " + "Total: " + String.Format("{0:0.00}", Math.Round(sum, 2)));
        }

    }
}
