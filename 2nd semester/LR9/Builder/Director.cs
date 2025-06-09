using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LR9.Staff;
using LR9.DiagnosisServices;

namespace LR9.Builder
{
    public static class Director
    {
        public static MedStaff GetPhysicalExamMedic(string name, MedStaffBuilder builder)
            => builder.SetName(name).SetDiagnosis(new PhysicalExam()).Build();
        public static MedStaff GetMRIMedic(string name, MedStaffBuilder builder)
            => builder.SetName(name).SetDiagnosis(new MRI()).Build();
        public static MedStaff GetXrayMedic(string name, MedStaffBuilder builder)
            => builder.SetName(name).SetDiagnosis(new Xray()).Build();
        public static MedStaff GetSecondMedic(string name, MedStaffBuilder builder)
            => builder.SetName(name).SetCathegory(Cathegory.Second).SetDiagnosis(new PhysicalExam()).Build();
    }
}