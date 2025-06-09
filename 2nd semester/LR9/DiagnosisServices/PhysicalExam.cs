using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR9.DiagnosisServices
{
    public class PhysicalExam : IDiagnosis
    {
        public void Diagnose() => Console.WriteLine("Performing Physical diagnosis");
    }
}