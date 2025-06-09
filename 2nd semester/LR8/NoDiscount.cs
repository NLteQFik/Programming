using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR8
{
    internal class NoDiscount : IDiscount
    {
        public decimal GetDiscount()
        {
            return 1m;
        }
    }
}