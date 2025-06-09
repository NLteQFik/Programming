using LR9.Builder;
using LR9.Staff;
using LR9.SpecialFunctionsServices;
using LR9.DiagnosisServices;

var listStaff = new List<MedStaff>();

var nurseBuilder = new NurseBuilder();
var firstSurgeonBuilder = new SurgeonBuilder().SetCathegory(LR9.Cathegory.First);
var higherSurgeonBuilder = new SurgeonBuilder().SetCathegory(LR9.Cathegory.Higher);
var therapistBuilder = new TherapistBuilder();

listStaff.AddRange(new MedStaff[] 
{
    Director.GetSecondMedic("Ann", nurseBuilder),
    Director.GetMRIMedic("John", firstSurgeonBuilder),
    Director.GetXrayMedic("Carl", higherSurgeonBuilder),
    Director.GetPhysicalExamMedic("Jacob", therapistBuilder)
});

foreach (MedStaff medic in listStaff)
{
    medic.GetInfo();
    medic.Diagnose();

    if (medic is Nurse)
    {
        ((Nurse)medic).Inject();
        ((Nurse)medic).DoLigation();
    }

    if (medic is Surgeon) ((Surgeon)medic).DoSurgery();

    if (medic is Therapist) ((Therapist)medic).IssueSickNote();

    Console.WriteLine("-----------------------");
}
