using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab7
{
    public class Student:People
    {
        protected int Kyrs { get; set; }
        protected int Group { get; set; }
        protected string Fakyltet { get; set; }
        protected string VNZ { get; set; }

        public Student(int kyrs, int group, string fakyltet, string vNZ,string name,string surname,string date)
        {
            Kyrs = kyrs;
            Group = group;
            Fakyltet = fakyltet;
            VNZ = vNZ;
            Name = name;
            Surname = surname;
            Date = date;
        }
        public Student()
        {
            Kyrs = 1;
            Group = 121;
            Fakyltet = "FIKT";
            VNZ = "ZTU";
            Name = "Ivan";
            Surname = "Ivanov";
            Date = "10.11.2003";

        }
        public Student(int kyrs,int group)
        {
            Kyrs = kyrs;
            Group = group;
            Fakyltet = "FIKT";
            VNZ = "ZTU";
            Name = "Vladislav";
            Surname = "Capones";
            Date = "10.11.2003";
        }
        public Student(Student obj)
        {
            Kyrs = obj.Kyrs;
            Group = obj.Group;
            Fakyltet = obj.Fakyltet;
            VNZ = obj.VNZ;
            Name = obj.Name;
            Surname = obj.Surname;
            Date = obj.Date;
        }
        public void ShowInfo(Student student)
        {
            Console.WriteLine($"Ім'я:{student.Name}");
            Console.WriteLine($"Прізвище:{student.Surname}");
            Console.WriteLine($"Дата народження:{student.Date}");
            Console.WriteLine($"Курс:{student.Kyrs}");
            Console.WriteLine($"Група:{student.Group}");
            Console.WriteLine($"Факультет:{student.Fakyltet}");
            Console.WriteLine($"Вищий навчальний заклад:{student.VNZ}");
        }
    }
}
