using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR8
{
    internal class Discount : IDiscount
    {
        private decimal discount;
        public Discount(decimal discount)
        { 
            this.discount = discount;
        }
        public decimal GetDiscount()
        {
            return discount;
        }
    }
}