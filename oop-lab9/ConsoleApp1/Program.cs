using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture =
                 (System.Globalization.CultureInfo)
                  System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Лабораторна робота №9.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4(2)\nВаріант №4.\nЗавдання 1.\n");
            Console.Title = "Лабораторна робота №9";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Уведіть чисельник(перше число):");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Уведіть знаменик(перше число):");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Уведіть чисельник(друге число):");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Уведіть знаменик(друге число):");
            int y2 = int.Parse(Console.ReadLine());
            Fraction a = new Fraction(x1, y1);
            Fraction b = new Fraction(x2, y2);
            Console.WriteLine("Перевантажуємо операції");
            Console.WriteLine("Унарне додавання:");
            Console.WriteLine(+a);
            Console.WriteLine("Унарне віднімання:");
            Console.WriteLine(-a);
            Console.WriteLine("Бінарне додавання:");
            Console.WriteLine(a + b);
            Console.WriteLine("Бінарне віднімання:");
            Console.WriteLine(a - b);
            Console.WriteLine("Бінарне множення:");
            Console.WriteLine(a * b);
            Console.WriteLine("Бінарне ділення:");
            Console.WriteLine(a / b);
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Бінарна операція <");
            Console.WriteLine(a < b );
            Console.WriteLine("Бінарна операція >");
            Console.WriteLine(a > b);
            Console.WriteLine("Бінарна операція <=");
            Console.WriteLine(a <= b);
            Console.WriteLine("Бінарна операція >=");
            Console.WriteLine(a >= b);
            Console.WriteLine("Бінарна операція ==");
            Console.WriteLine(a == b);
            Console.WriteLine("Бінарна операція !=");
            Console.WriteLine(a != b);
            Console.WriteLine("Скорочення дробу:");
            Fraction.Cut(a);
            Console.WriteLine("Переведення до double:");
            Console.WriteLine($"{Fraction.ToDouble(a)}");
            Console.ResetColor();
        }
    }
}