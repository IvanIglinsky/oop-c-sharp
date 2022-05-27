using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab7
{
    public class Teacher:People
    {
        protected string Posada { get; set; }
        protected string Kafedra { get; set; }
        protected string VNZ { get; set; }
        public Teacher(string posada, string kafedra, string vNZ,string name,string surname,string date)
        {
            Posada = posada;
            Kafedra = kafedra;
            VNZ = vNZ;
            Name = name;
            Surname = surname;
            Date = date;
        }
        public Teacher()
        {
            Posada = "MainTeacher";
            Kafedra = "FIKT";
            VNZ = "ZTU";
            Name = "Roman";
            Surname = "Romanov";
            Date = "05.10.1985";
        }
        public Teacher(string posada,string kafedra)
        {
            Posada = posada;
            Kafedra = kafedra;
            VNZ = "ZTU";
            Name = "Oleg";
            Surname = "Olegov";
            Date = "15.01.1988";
        }
        public Teacher(Teacher obj)
        {
            Posada = obj.Posada;
            Kafedra = obj.Kafedra;
            VNZ = obj.VNZ;
            Name = obj.Name;
            Surname = obj.Surname;
            Date = obj.Date;
        }
        public void ShowInfo(Teacher teacher)
        {
            Console.WriteLine($"Ім'я:{teacher.Name}");
            Console.WriteLine($"Прізвище:{teacher.Surname}");
            Console.WriteLine($"Дата народження:{teacher.Date}");
            Console.WriteLine($"Посада:{teacher.Posada}");
            Console.WriteLine($"Кафедра:{teacher.Kafedra}");
            Console.WriteLine($"Вищий навчальний заклад:{teacher.VNZ}");

        }
    }
}
