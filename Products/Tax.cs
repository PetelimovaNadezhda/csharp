using System;

namespace Products1
{
   public class Tax : ITaxCalculator
    {
        public double taxImported = 0.05;
        public double taxProducts = 0.1;

        public double Cost(Products p)
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
