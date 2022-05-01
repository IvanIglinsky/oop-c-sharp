using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1DConsole
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
            int n, i = 0;
            Console.WriteLine("Лабораторна робота №3.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4(2)\nВаріант №4.\nЗавдання 1.");
            do
            {
                Console.Write("Введіть  значення n= ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення n. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            Random rnd = new Random();
            double dob = 1;
            double[] arr = new double[n];
            for (i = 0; i < n; i++)
            {
                double x = Convert.ToDouble(rnd.Next(-54, 57) / 10.0);
                double d = rnd.NextDouble();
                Console.Write("{0:F1}; ", x);
                if (x < 0.0)
                    dob *= Math.Abs(x);  
                arr[i] = x;
            }
            Console.WriteLine("\n1)Добуток модулів ={0:F1}", dob);
            Console.WriteLine("2)Сортований масив:");
            int index = 0;          
            for (i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    index = i;
                    break;
                }
            }
            Array.Sort(arr, 0, index);
            for (i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]:F1}, ");              
            }
        }
    }
}

