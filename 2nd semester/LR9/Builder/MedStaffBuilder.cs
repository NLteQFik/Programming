using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.DiagnosisServices;
using LR9.Staff;

namespace LR9.Builder
{
    public abstract class MedStaffBuilder
    {
        protected string name = string.Empty;
        protected Cathegory cathegory = Cathegory.Second;
        protected IDiagnosis? diagnosis;

        public MedStaffBuilder SetName(string name)
        { this.name = name; return this; }
        public MedStaffBuilder SetCathegory(Cathegory cathegory)
        { this.cathegory = cathegory; return this; }
        public MedStaffBuilder SetDiagnosis(IDiagnosis diagnosis)
        { this.diagnosis = diagnosis; return this; }

        public abstract MedStaff Build();
    } 
}