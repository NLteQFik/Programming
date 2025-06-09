using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.Staff;

namespace LR9.Builder
{
    public class TherapistBuilder : MedStaffBuilder
    {
        public override MedStaff Build()
        {
            var therapist = new Therapist { Name = name, Cathegory = cathegory };
            if (diagnosis != null)
                therapist.SetDiagnosis(diagnosis);
            return therapist;
        }
    }
}