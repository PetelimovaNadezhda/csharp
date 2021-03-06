﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Products1
{
    public class Parsing
    {
        public static Dictionary<string, List<IProduct>> ParsingInput(string path)
        {
            Dictionary<string, List<IProduct>> baskets = new Dictionary<string, List<IProduct>>();
            List<IProduct> productsInBasket = new List<IProduct>();
            StreamReader reader = File.OpenText(path);
            string line = reader.ReadLine();
            int countBasket = 0;
            while (line != null && line.Contains("Shopping Basket"))
            {
                countBasket++;
                productsInBasket.Clear();
                while ((line = reader.ReadLine()) != null && !line.Contains("Shopping Basket"))
                {
                    productsInBasket.Add(LineToProductParsing(line));
                }
                baskets.Add("Output " + countBasket, new List<IProduct>(productsInBasket));
            }
            return baskets;
        }

        public static Products LineToProductParsing(string line)
        {
            String name;
            bool book = false;
            bool food = false;
            bool medical = false;
            bool imported = false;
            double price = 0;

            if (line.Contains("imported")) imported = true;
            if (Enum.GetNames(typeof(Food)).Any(e => line.Contains(e))) food = true;
            if (Enum.GetNames(typeof(Medical)).Any(e => line.Contains(e))) medical = true;
            if (Enum.GetNames(typeof(Book)).Any(e => line.Contains(e))) book = true;

            line = new Regex(@"^[^\d]+").Replace(line, "");
            int count = Int32.Parse(new Regex(@"[^\d]+.+").Replace(line, ""));
            price = Double.Parse(new Regex(@".+at ").Replace(line, ""));
            name = new Regex(@" at.+").Replace(line, "");

            return new Products(name, book, food, medical, imported, price, count);
        }
    }
}
