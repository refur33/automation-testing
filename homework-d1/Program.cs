using System;
using homework_d1;

Surgeon slava = new Surgeon("Vyacheclav", "Mon, Wed, Fri", "Plastic surgery");
Surgeon sveta = new Surgeon("Svetlana", "Tue, Fri", "Neurosurgery");
Surgeon sava = new Surgeon("Savelii", "Mon, Sat", "Abdominal surgery");
Nurse kolya = new Nurse("Nikolai", "Laboratory");
Nurse nadya = new Nurse("Nadezhda", "Palliative care");
Dentist dasha = new Dentist("Darya");
Dentist dima = new Dentist("Dmitry");


List<Surgeon> surgeryDepartment = new List<Surgeon>();
surgeryDepartment.Add(slava);
surgeryDepartment.Add(sveta);
surgeryDepartment.Add(sava);

List<Nurse> nursery = new List<Nurse>();
nursery.Add(kolya);
nursery.Add(nadya);

List<Dentist> dentalDepartment = new List<Dentist>();
dentalDepartment.Add(dasha);
dentalDepartment.Add(dima);



//foreach (Doctor doctor in doctors)
//{
//    doctor.Treat();
//}
int option;
Console.WriteLine("Select required department. Enter:");
Console.WriteLine("1 - Surgery;");
Console.WriteLine("2 - Nursery;");
Console.WriteLine("3 - Dental;");
option = Convert.ToInt32(Console.ReadLine());

if (option == 1)
{
    foreach (Surgeon surgeon in surgeryDepartment)
    {
        surgeon.SurgeonInfo;
    }
}
else if (option == 2)
{
    foreach (Nurse nurse in nursery)
    {
        nurse.NurseInfo;
    }
}
else if (option == 3)
{
    foreach (Dentist dentist in dentalDepartment)
    {
        dentist.DentistInfo();
    }
}
else
{
    Console.WriteLine("try again");
}
    