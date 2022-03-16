using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double x, y, z;
            bool ok;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4(2)\nВаріант №4.\nЗавдання 1.");
            do
            {
                Console.Write("Введіть  значення x = ");
                ok = double.TryParse(Console.ReadLine(), out x);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення x. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть значення y = ");
                ok = double.TryParse(Console.ReadLine(), out y);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення y. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть  значення z = ");
                ok = double.TryParse(Console.ReadLine(), out z);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення z. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            double s = Math.Pow((Math.Cos(x)-Math.Sin(y)),(1+2*Math.Sin(z)))*(z+Math.Pow(z,2)/2+ Math.Pow(z, 3) / 3)+ Math.Pow(z, 4) / 4;
            Console.WriteLine("Результат обчислення: s = {0:F3}", s);
            Console.ReadKey();
        }
    }
}
