using System;
using System.Collections.Generic;
using System.Text;

namespace _0211hmw
{
    class Human
    { public Human (string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }
        string Name;
        string Surname;
        string Gender;
        public virtual void ShowInfo()
        { Console.WriteLine($"Name; {Name}, Surname; {Surname}, Gender; {Gender}"); }


    }
}
