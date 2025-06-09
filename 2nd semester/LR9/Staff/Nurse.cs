using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.SpecialFunctionsServices;

namespace LR9.Staff
{
    public class Nurse : MedStaff, ILigation, IInjection
    {
        public override void GetInfo()
            => Console.WriteLine($"I'm {Name} a nurse with {Cathegory} cathegory");

        public void DoLigation() => Console.WriteLine("Doing a ligation");

        public void Inject() => Console.WriteLine("Doing an injection");
    }
}