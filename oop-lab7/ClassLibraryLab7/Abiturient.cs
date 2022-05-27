using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab7
{
    public class Abiturient:People
    {
        protected int PointsZNO { get; set; }
        protected int PointsDocOsvita { get;set; }
        protected string NameOsvita { get;set; }

        public Abiturient(int pointsZNO, int pointsDocOsvita, string nameOsvita,string name,string surname,string date)
        {
            PointsZNO = pointsZNO;
            PointsDocOsvita = pointsDocOsvita;
            NameOsvita = nameOsvita;
            Name = name;
            Surname = surname;
            Date = date;
        }
       public Abiturient()
        {
            PointsZNO = 200;
            PointsDocOsvita = 10;
            NameOsvita = "liceum";
            Name = "Volodymir";
            Surname = "Zelenskyi";
            Date = "10.05.1980";
        }
        public Abiturient(string nameOsvita)
        {
            PointsZNO = 150;
            PointsDocOsvita = 11;
            NameOsvita= nameOsvita;
            Name = "Viktor";
            Surname = "General";
            Date = "19.02.1989";
        }
        public Abiturient (Abiturient obj)
        {
            PointsDocOsvita= obj.PointsDocOsvita;
            PointsZNO = obj.PointsZNO;
            NameOsvita = obj.NameOsvita;
            Name= obj.Name;
            Surname = obj.Surname;
            Date=obj.Date;
        }
        public void ShowInfo(Abiturient abiturient)
        {
            Console.WriteLine($"Ім'я:{abiturient.Name}");
            Console.WriteLine($"Прізвище:{abiturient.Surname}");
            Console.WriteLine($"Дата народження:{abiturient.Date}");
            Console.WriteLine($"Кількість балів ЗНО:{abiturient.PointsZNO}");
            Console.WriteLine($"Кількість балів за документ про освіту:{abiturient.PointsDocOsvita}");
            Console.WriteLine($"Назва загальноосвітнього навчального закладу:{abiturient.NameOsvita}");
        }
    }
}
