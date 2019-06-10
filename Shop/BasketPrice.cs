using Products1;
using System;
using System.Collections.Generic;

namespace Shop
{
    public class BasketPrice
    {
        public string name;
        public BasketPrice(string name)
        {
            this.name = name;
        }

        public double tax = 0;
        public double sum = 0;
        public void PrintReceipt(List<IProduct> products)
        {
            foreach (IProduct p in products)
            {
                PrintProductPrice(p);
            }
            Console.WriteLine("     " + "Sales Taxes: " + String.Format("{0:0.00}", Math.Round(tax, 2)));
            Console.WriteLine("     " + "Total: " + String.Format("{0:0.00}", Math.Round(sum, 2)));
        }

        public string PrintProductPrice(IProduct p)
        {
            double currentTax = p.count * new Tax().Cost((Products) p);
            tax += currentTax;
            double price = p.price * p.count + currentTax;
            sum += price;

            string pricePrint = "     " + " " + p.name + ": " + String.Format("{0:0.00}", Math.Round(price, 2));
            Console.WriteLine(pricePrint);
            return pricePrint;              
        }
    }
}
