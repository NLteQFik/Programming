using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR5
{
    internal class Tariff
    {  
       public double Price { get; set; }
       public string Name { get; set; }

        public Tariff() 
        {
            Name = string.Empty;
            Price = 0;
        }
       public Tariff(string name, double price) 
        {
            Name = name;
            Price = price;
        }
    }
}
