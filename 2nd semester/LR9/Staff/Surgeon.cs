using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.SpecialFunctionsServices;

namespace LR9.Staff
{
    public class Surgeon : MedStaff, ISurgery
    {
        public override void GetInfo()
            => Console.WriteLine($"I'm {Name} a surgeon with {Cathegory} cathegory");

        public void DoSurgery() => Console.WriteLine("Performing a surgery");
    }
}