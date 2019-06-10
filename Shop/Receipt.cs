using Products1;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Shop
{
    class Receipt
    {
        public static void Main()
        {
            foreach (KeyValuePair<string, List<IProduct>> shop in Parsing.ParsingInput(ConfigurationManager.AppSettings["file"]))
            {
                Console.WriteLine(shop.Key + ":");
                new BasketPrice(shop.Key).PrintReceipt(shop.Value);
            }
        }
    }
}
