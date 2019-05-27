using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Receipt
    {
        public static Dictionary<int, Products> catalog = new Dictionary<int, Products>();

        public static void AddCatalog()
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Products[]));
            using (FileStream fs = new FileStream("C:/Users/Nadezhda_Petelimova/source/repos/Shop/catalog.json", FileMode.OpenOrCreate))
            {
                Products[] catalogJson = (Products[])jsonFormatter.ReadObject(fs);
           
                foreach (Products p in catalogJson)
                {
                    catalog.Add(p.id, p);
                }
            }
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

            Basket shop3 = new Basket("Output 3");
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
