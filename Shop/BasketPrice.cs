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

        double tax = 0;
        double sum = 0;
        public void PrintReceipt(List<Products> products)
        {
            foreach (Products p in products)
            {
                PrintProductPrice(p);
            }
            Console.WriteLine("     " + "Sales Taxes: " + String.Format("{0:0.00}", Math.Round(tax, 2)));
            Console.WriteLine("     " + "Total: " + String.Format("{0:0.00}", Math.Round(sum, 2)));
        }

        public void PrintProductPrice(Products p)
        {
            double currentTax = p.count * new Tax().Cost(p);
            tax += currentTax;
            double price = p.price * p.count + currentTax;
            sum += price;

            Console.WriteLine("     " + " " + p.name + ": " + String.Format("{0:0.00}", Math.Round(price, 2)));
        }
    }
}
