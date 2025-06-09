using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.DiagnosisServices;

namespace LR9.Staff
{
    public abstract class MedStaff
    {
        public Cathegory Cathegory { get; set; }
        public string Name { get; set; }
        protected IDiagnosis Diagnosis { get; set; }

        public abstract void GetInfo();

        public void SetDiagnosis(IDiagnosis diagnosis) => Diagnosis = diagnosis;
        public void Diagnose() => Diagnosis.Diagnose();
    }
}