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
            double k=1;
            bool ok;
            int n;
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4\nВаріант №4.\nЗавдання 3.");
            do
            {
                    Console.Write("Введіть значення N(N>0) = ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("Помилка введення значення N. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
           
            for(int i = 1; i <= n; i++)
            {
                do
                {
                    k += Math.Pow(i, (n + 1) - i);
                } while (Math.Pow(i, (n + 1) - 1) == n);
            }
            Console.WriteLine("Значення виразу={0:F0}", k);
        }
        
    }
}