using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnsoleApp2
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

            bool ok;
            double a,b,c;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4\nВаріант №4.\nЗавдання 1.");
            do
            {
                Console.Write("Введіть значення a = ");
                ok = double.TryParse(Console.ReadLine(), out a);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення a. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть значення b = ");
                ok = double.TryParse(Console.ReadLine(), out b);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення b. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть значення c = ");
                ok = double.TryParse(Console.ReadLine(), out c);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення c. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
                double res1,res2;
            if (a == 0)
            {
                res1 = 0;
                res1 = c / b;
                Console.WriteLine("Корінь = {0:F3}", res1);

            }
            else
            {
                double s = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine("Дискримінант = {0:F3}", s);
                if (s > 0)
                {
                    res1 = ((-b) - (Math.Sqrt(s))) / 2 * a;
                    res2 = ((-b) + (Math.Sqrt(s))) / 2 * a;
                    Console.WriteLine("Перший корінь = {0:F3}", res1);
                    Console.WriteLine("Другий корінь = {0:F3}", res2);
                }
                if (s < 0)
                {
                    Console.WriteLine("Коренів не існує");

                }
                if (s == 0)
                {
                    res1 = 0;
                    res1 = -(b / 2 * a);
                    Console.WriteLine("Корінь = {0:F3}", res1);
                }
            }
        }
    }
}