using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassLibrary
{
    public class Result
    {
        protected string Subject;
        protected string Teacher;
        protected int Points;
        public string GetSubjectG()
        {
            return Subject;
        }
        public void SetSubjectG(string value)
        {

            Subject = value;
        }
        public string GetTeacherG()
        {
            return Teacher;
        }

        public void SetTeacherG(string value)
        {
            Teacher = value;
        }
        public int GetPointsG()
        {
            return Points;
        }
        public void SetPointsG(int value)
        {
            Points = value;
        }
        public Result(string subject, string teacher, int points)
        {
            Subject = subject;
            Teacher = teacher;
            Points = points;

        }
        public Result()
        {
            Subject = "Помилка";
            Teacher = "POMYLKA";
            Points = 0;

        }
        public Result(string subject)
        {
            Subject = subject;
            Teacher = "Іванов";
            Points = 30;

        }
        public Result(Result obj)
        {
            Subject = obj.Subject;
            Teacher = obj.Teacher;
            Points = obj.Points;


        }
        public double GetAveragePoints(Student[] students)
        {
            int arraysSum = 0;
            for (int i = 0; i < students.Length; i++)
                arraysSum += students[i].Results.GetPointsG();
            double Average = arraysSum / students.Length;
            return Average;
        }
        public string GetBestSubject(Student[] students)
        {
            int max = -99999;
            int index = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Results.GetPointsG() > max)
                {
                    max = students[i].Results.GetPointsG();
                    index = i;

                }
            }
            return students[index].Results.GetSubjectG();
        }
        public string GetWorstSubject(Student[] students)
        {
            int min = 99999;
            int index = 0;

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Results.GetPointsG() < min)
                {
                    min = students[i].Results.GetPointsG();
                    index = i;
                }
            }
            return students[index].Results.GetSubjectG();
        }
    }
}
