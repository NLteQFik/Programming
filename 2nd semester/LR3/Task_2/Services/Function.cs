using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Services
{
    class Function(double c, double d, double k, double z)    
    {        
        private int branch = 0;        

        public double ComputeFunction()
        {
            double x;
            if (z < 0)
            {
                x = z * z - z;
                branch = 1;
            }
            else
            {
                x = z * z * z;
                branch = 2;
            }
            return Math.Pow(Math.Sin(c * x + d * d + k * x * x), 3);
        }

        public int GetBranch()
        {
            return branch;
        }
    }
}
