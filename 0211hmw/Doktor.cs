using System;
using System.Collections.Generic;
using System.Text;

namespace _0211hmw
{
    class Doctor : Human
    {
        public Doctor(string name, string surname, string gender, int no, string speciality, int experience):base (name,surname,gender)
        {   this.No = no;
            this.Speciality = speciality;
            this.Experience = experience;
        }
        int No;
        string Speciality;
        int Experience;
        public override void ShowInfo()
        {
             base.ShowInfo();
            Console.WriteLine($"No; {No}, Speciality; {Speciality}, Experience; {Experience}");
        }
        //Doctor[] doctors = null;
        public static Doctor[] AddDoctor(Doctor [] doctors, Doctor doctor)
        {
            Array.Resize(ref doctors, doctors.Length + 1);
            doctors[doctors.Length - 1] = doctor;
            return doctors;
        }
    }
}
