using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{

    class Calc
    {
        public static double taxImported = 0.05;
        public static double taxProducts = 0.1;

        public static double Cost(Products p)
        {
            double cost = 0;

            if (p.book == false && p.food == false && p.medical == false)
            {
                cost += Math.Ceiling(p.price * taxProducts * 20.0) / 20.0;
            }
            if (p.imported == true)
            {
                cost += Math.Ceiling(p.price * taxImported * 20.0) / 20.0;
            }
            return cost;
        }
    }
}
