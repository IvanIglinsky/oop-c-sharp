using System;

namespace SimpleClassLibrary
{
    public class Student
    {
        protected string Name;
        protected string Surname;
        protected int Group;
        protected int Year;
        public Result Results;
        public string GetNameG()
        {
            return Name;
        }

        public void SetNameG(string value)
        {
            if (value.Length > 0)
                Name = value;
        }
        public string GetSurnameG()
        {

            return Surname;
        }

        public void SetSurnameG(string value)
        {
            if (value.Length > 0)
                Surname = value;
        }
        public int GetGroupG()
        {
            return Group;
        }
        public void SetGroupG(int value)
        {
            if (value > 0)
                Group = value;
        }
        public int GetYearG()
        {
            return Year;
        }
        public void SetYearG(int value)
        {
            if (value > 0 && value < 5)
                Year = value;
        }
        public Student(string name, string surname, int group, int year, Result results)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Year = year;
            Results = new Result();
        }
        public Student()
        {
            Name = "IVAN";
            Surname = "IVANOV";
            Group = 121;
            Year = 1;
            Results = new Result();
        }
        public Student(string name, int group, Result results)
        {
            Name = name;
            Surname = "IGLINSKYI";
            Group = group;
            Year = 2021;
            Results = results;
        }
        public Student(Student obj)
        {
            Name = obj.Name;
            Surname = obj.Surname;
            Group = obj.Group;
            Year = obj.Year;
            Results = new Result(obj.Results);
        }
        public double Price(int MENU)
        {
            double month = 2800;
            double year = month * 10;
            double All = month * 40;
            switch(MENU)
            {
                case 1:
                    return month;
                    break;
                case 2:
                    return year;
                    break;
                case 3:
                    return All;
                    break;
            }
            return 0;
        }
    }
}