using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using SimpleClassLibrary;

namespace SimpleClassConlsole
{ 
    class Program
    {
        static void Check(out int x)
        {
            bool ok;
            do
            {
                ok = int.TryParse(Console.ReadLine(), out x);
                if (!ok)
                {
                    Console.WriteLine("Введені дані некоректні! Повторіть введення.");
                }
            } while (!ok);
        }
        static Student[] ReadStudentsArray()
        {
            Console.Write("Введіть кількість студентів = ");
            int n; Check(out n);
            Student[] students;
            Student stud = new Student();
            students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = new Student();
                Console.Write($"Введіть Імя {i + 1} студента = ");
                students[i].SetNameG(Console.ReadLine());
                Console.Write($"Введіть Прізвище {i + 1} студента = ");
                students[i].SetSurnameG(Console.ReadLine());
                Console.WriteLine($"Введіть групу {i + 1} студента = ");
                while (true)
                {
                    try
                    {
                        students[i].SetGroupG(int.Parse(Console.ReadLine()));
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("ERROR");
                    }
                }
                Console.WriteLine($"Введіть номер курсу {i + 1} студента = ");
                while (true)
                {
                    try
                    {
                        students[i].SetYearG(int.Parse(Console.ReadLine()));
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("ERROR");
                    }
                }

                Console.Write("Введіть назву предмета = ");
                students[i].Results.SetSubjectG(Console.ReadLine());
                Console.Write("Введіть результат = ");
                while (true)
                {
                    try
                    {
                        students[i].Results.SetPointsG(Convert.ToInt32(Console.ReadLine()));
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("ERROR");
                    }
                }
                    Console.Write($"Введіть прізвище та ініціали {i + 1} викладача = ");
                    students[i].Results.SetTeacherG(Console.ReadLine());
               
            }
            return students;
        }
        public static void PrintStudet(Student x, Student[]students)
        {
          
            Console.WriteLine($"Ім'я студента:{x.GetNameG()}");
            Console.WriteLine($"Прізвище студента:{x.GetSurnameG()}");
            Console.WriteLine($"Група:{x.GetGroupG()}");
            Console.WriteLine($"Курс:{x.GetYearG()}");
            Console.WriteLine($"Назва предмету:{x.Results.GetSubjectG()}");
            Console.WriteLine($"Оцінка:{x.Results.GetPointsG()}");
            Console.WriteLine($"Прізвище та ініціали викладача:{x.Results.GetTeacherG()}");
            Console.WriteLine($"Найкраща оцінка з {x.Results.GetBestSubject(students)}");
            Console.WriteLine($"Найгірша оцінка з {x.Results.GetWorstSubject(students)}");
           
        }
        public static void PrintStudets(Student[]students)
        { 
            for (int i = 0; i < students.Length; i++)
            {
              Console.ForegroundColor=ConsoleColor.Yellow;
                Console.Write($"\tСтудент №{i + 1}\n");
                PrintStudet(students[i],students);
            }
        }
        public static void GetStudentsInfo( out int mini, out int max, Student[]students)
        {
            max = -99999;
            mini = 99999;
            int arraysSum = 0;
            for (int i = 0; i < students.Length; i++)
                arraysSum += students[i].Results.GetPointsG();
            int res = arraysSum / students.Length;
            for (int i = 0; i < students.Length; i++)
            {
                if (res > max)
                    max = i;
                if (res < mini)
                    mini = i;
            }
            res = 0;
        }
        public static void SortStudentsByPoints(Student[] students)
        {
            double[] arrTMP = new double[students.Length];
            for (int i = 0; i < students.Length; i++)
                arrTMP[i] = students[i].Results.GetPointsG();
            Array.Sort(arrTMP, students);
            Array.Reverse(students);
            PrintStudets(students);
        }
        public static void SortStudentsByName(Student[] students)
        {

            string[] arrTMP = new string[students.Length];
            for (int i = 0; i < students.Length; i++)
                arrTMP[i] = students[i].GetNameG();
            Array.Sort(arrTMP, students);
            Array.Reverse(students);
            PrintStudets(students);
        }
        public static int PrintMenu()
        {
            Console.WriteLine("  ");
            Console.WriteLine("Виберіть пункт меню:");
            Console.WriteLine("1-Ввести нового студента");
            Console.WriteLine("2-Виведення студента");
            Console.WriteLine("3-Максимальний та мінімальний середній бал");
            Console.WriteLine("4-Сортований масив за зростанням середнього балу");
            Console.WriteLine("5-Сортований масив за прізвищем");
            Console.WriteLine("6-Виведення вартості навчання");
            Console.WriteLine("7-Вийти з меню");
            int menu;Check(out menu);
            Console.ForegroundColor = ConsoleColor.Green;
            return menu;
        }
        public static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Лабораторна робота №5.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4(2)\nВаріант №4.\nЗавдання 1.");
            Console.Title = "Лабораторна робота №5";
            Console.SetWindowSize(110, 40);
            Student[] students = ReadStudentsArray();
            Student stud=new Student();
            PrintStudets(students);
            int yesNo = 0;
            int menu;
            bool end = true;
            do
            {
              Console.BackgroundColor = ConsoleColor.Green;
              Console.ForegroundColor = ConsoleColor.Red;
              menu = PrintMenu();
              Console.ResetColor();
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        students=ReadStudentsArray();
                        break;
                    case 2:
                        Console.WriteLine("Вивести усіх студентів - 1");
                        Console.WriteLine("Вивести обраного студента - 2");
                        Console.WriteLine("Повернутись до меню - 0");
                        Check(out menu);
                       switch(menu)
                        {
                            case 1:
                                Console.Clear();
                                PrintStudets(students);
                                break;
                            case 2:
                                Console.WriteLine("Введіть номер обраного струдента: ");
                                int x; Check(out x);
                                Console.Clear();
                                PrintStudet(students[x - 1],students);
                                break;
                            case 3:
                                break;
                        }
                        break;
                    case 3:
                        int mini, max;
                        GetStudentsInfo(out mini, out max, students);
                        Console.WriteLine($"Найвищий бал з {students[max].Results.GetBestSubject(students)}");
                        Console.WriteLine($"Найгірший бал з {students[mini].Results.GetWorstSubject(students)}");
                        break;
                    case 4:
                        SortStudentsByPoints(students);
                        PrintStudets(students);
                        break;
                    case 5:
                        SortStudentsByName(students);
                        PrintStudets(students);
                        break;
                    case 6:
                        Console.WriteLine("Введіть одиниці вимірювання оплати за навчання\n1-За місяць\n2-За рік\n3-За весь період");
                        Check(out int MENU);
                        Console.WriteLine($"Вартість навчання:{stud.Price(MENU)}");
                        break;

                }
                Console.WriteLine("Поверунтись до меню");
                Console.WriteLine("1-так,2-ні");
                yesNo = Convert.ToInt32(Console.ReadLine());
                if (yesNo == 1)
                    end = true;
                if (yesNo == 2)
                    end = false;
                Console.ResetColor();
            } while (end);
        }
    }
}
