﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LR9.DiagnosisServices
{
    public class Xray : IDiagnosis
    {
        public void Diagnose() => Console.WriteLine("Performing Xray diagnosis");
    }
}