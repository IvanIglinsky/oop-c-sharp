using System;
using ClassLibraryLab7;
using System.Text;

namespace ConsoleLab7
{
    class Program
    {

        static void Main(string[]args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                            System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Лабораторна робота №7.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4(2)\nВаріант №4.\nЗавдання 1.\n");
            Console.Title = "Лабораторна робота №7";
            Console.ResetColor();
            Abiturient abiturient = new Abiturient();
            Student student = new Student();
            Teacher teacher = new Teacher();
            UsersBibliotek usersBibliotk = new UsersBibliotek();
            int yesNo=0;
            bool end=true;
            do
            {
              
                Console.ForegroundColor = ConsoleColor.Red;

                int menu;
                Console.WriteLine("Виберіть пункт меню:");
                Console.WriteLine("1-Абітурєнт");
                Console.WriteLine("2-Студент");
                Console.WriteLine("3-Викладач");
                Console.WriteLine("4-Користувач бібліотеки");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        abiturient.ShowInfo(abiturient);
                        break;
                    case 2:
                        student.ShowInfo(student);
                        break;
                    case 3:
                        teacher.ShowInfo(teacher);
                        break;
                    case 4:
                        usersBibliotk.ShowInfo(usersBibliotk);
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Поверунтись до меню");
                Console.WriteLine("1-так,2-ні");
                Console.ForegroundColor = ConsoleColor.Red;
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