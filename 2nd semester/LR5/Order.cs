using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Order
    {
        public string Name { get; set; }

        public Tariff Tariff { get; set; }

        public double Volume { get; set; }

        public Order()
        {
            Name = string.Empty;
            Tariff = new Tariff();
            Volume = 0;
        }

        public Order(string name, Tariff tariff, double volume)
        { 
            Name = name;
            Tariff = tariff;
            Volume = volume;
        }

        public double GetPrice()
        {
            return Volume * Tariff.Price;
        }
        
    }
}
