using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.SpecialFunctionsServices;

namespace LR9.Staff
{
    public class Therapist : MedStaff, ISickNote
    {
        public override void GetInfo()
            => Console.WriteLine($"I'm {Name} a therapist with {Cathegory} cathegory");

        public void IssueSickNote() => Console.WriteLine("Giving a sick note");
    }
}