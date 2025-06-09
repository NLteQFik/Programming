using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Parity
    {
        private int number;
        public int Number
        {
            get { return number % 2 == 1 
                    ? 0 
                    : number / 2; }
            set { number = value; }
        }
    }
}
