using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.Staff;

namespace LR9.Builder
{
    public class NurseBuilder : MedStaffBuilder
    {
        public override MedStaff Build()
        {
            var nurse = new Nurse { Name = name, Cathegory = cathegory };
            if (diagnosis != null)
                nurse.SetDiagnosis(diagnosis);
            return nurse;
        }
    }
}