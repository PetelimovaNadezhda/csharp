using Products1;
using System;
using System.Collections.Generic;

namespace Shop
{
    class Receipt
    {
        public static void Main()
        {
            foreach (KeyValuePair<string, List<Products>> shop in Parsing.parsingInput("Input.txt"))
            {
                Console.WriteLine(shop.Key + ":");
                new BasketPrice(shop.Key).PrintReceipt(shop.Value);
            }
        }
    }
}
