using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR8
{
    internal class Tariff : IComparable<Tariff>
    {
        private IDiscount discount;
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Tariff(decimal price, IDiscount discount, string name)
        {
            Price = price;
            Name = name;
            this.discount = discount;
        }
        public void ChangeDiscount(IDiscount discount)
        {
            this.discount = discount;
        }
        public decimal GetPrice()
        {
            return Price * discount.GetDiscount();
        }

        public int CompareTo(Tariff other) => GetPrice().CompareTo(other.GetPrice());
    }
}