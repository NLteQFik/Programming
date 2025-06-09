using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.Staff;

namespace LR9.Builder
{
    public class SurgeonBuilder : MedStaffBuilder
    {
        public override MedStaff Build()
        {
            var surgeon = new Surgeon { Name = name, Cathegory = cathegory };
            if (diagnosis != null)
                surgeon.SetDiagnosis(diagnosis);
            return surgeon;
        }
    }
}