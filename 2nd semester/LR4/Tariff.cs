using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    internal class Tariff
    {
        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Tariff()
        { 
            price = 0; 
        }

        public Tariff(double price) 
        { 
            this.price = price;
        }

        public void changeTariff(double price) 
        {
            this.price += price;
        }
    }
}
