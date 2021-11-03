using System;

namespace _0211hmw
{
    class Program
    {
        static void Main(string[] args)
        {
            int say;
            string saystr;
            Doctor[] doctors = new Doctor [0];
            
            do
            {
                Console.WriteLine("Doctorlarin sayini daxil edin;");
                saystr = Console.ReadLine();
            } while (!int.TryParse(saystr,out say)|| say<=0);
            for (int i = 0; i < say; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"{i + 1} doktorun melumatlari;");
                Console.WriteLine("------------------------");
                string name = GetInfoStr("adini", 3, 20);
                string surname = GetInfoStr("soyadini", 3, 30);
                string gender = GetInfoStr("gender", 1, 10);
                string speciality = GetInfoStr("speciality");
                int no = GetInfoInt("no deyerini");
                int experience = GetInfoInt("experience (il olaraq)");
                Doctor doctor = new Doctor(name, surname, gender, no, speciality, experience);
               doctors = Doctor.AddDoctor(doctors,doctor);

            }
            foreach (var item in doctors)
            {
                Console.WriteLine("----------------");
                item.ShowInfo();
            }

        }
        static string GetInfoStr (string info,int min=0,int max=int.MaxValue)
        {
            string infostr;
            do
            {
                Console.WriteLine($"Doctorun {info} daxil edin;");
                 infostr = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(infostr) || infostr.Length<min || infostr.Length>max);
            return infostr;
        }
        static int GetInfoInt(string info, int min = 0, int max = int.MaxValue)
        { int infoint;
            string infostr;
            do
            {
                Console.WriteLine($"Doctorun {info} daxil edin;");
                infostr = Console.ReadLine();

            } while (!int.TryParse(infostr,out infoint)|| infoint <= min || infoint > max);
            return infoint;
        }
    }
}

