using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    [DataContract]
    class Products
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public String name { get; set; }
        [DataMember]
        public bool book { get; set; }
        [DataMember]
        public bool food { get; set; }
        [DataMember]
        public bool medical { get; set; }
        [DataMember]
        public bool imported { get; set; }
        [DataMember]
        public double price { get; set; }

        public Products(int id, string name, bool book, bool food, bool medical, bool imported, double price)
        {
            this.id = id;
            this.name = name;
            this.book = book;
            this.food = food;
            this.medical = medical;
            this.imported = imported;
            this.price = price;
        }
    }
}

