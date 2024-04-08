using Static_Interface2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Interface2.Moduls
{
    internal class Student : IcodeAcademy
    {
        public static int count;
        public int id;
        public string name;
        public string surname;

        public int Count { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CodeAcademy { get ; set ; }


        public Student(string name,string surname)
        {
            Id=Count++;
            Name=name;
            Surname=surname;
          
        }

        public static void CheckName()
        {
            
        }

       

        public void GeneratedEmail()
        {
            string email = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";
            CodeAcademy = email;
        }
    }
}
