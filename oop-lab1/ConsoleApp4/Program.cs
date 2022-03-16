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
            double s = 0;
            bool ok;
            int n,k;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4\nВаріант №4.\nЗавдання 1.");
            do
            {
                Console.Write("Введіть значення N(N>0) = ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Помилка введення значення N. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть значення K(K>0) = ");
                ok = int.TryParse(Console.ReadLine(), out k);
                if (!ok)
                    Console.WriteLine("Помилка введення значення K. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            for (int i = 1; i <= n; i++)
            {  
               s+=Math.Pow(i,k);
            }
            Console.WriteLine("Значення виразу={0:F0}", s+Math.Pow(n,k));
        }

    }
}