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
            int n = 1, par = 0, nepar = 0,plus=0,minus=0; 
            Console.WriteLine("Лабораторна робота №1.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4\nВаріант №4.\nЗавдання 1.");
                Console.Write("Введіть числа:");
            do
            {
                do
                {
                    ok = int.TryParse(Console.ReadLine(), out n);
                    if (n % 2 == 0)
                    {
                        par++;
                    }
                    if (n % 2 != 0)
                    {
                        nepar++;
                    }
                    if (n > 0)
                        plus++;
                    if (n < 0)
                        minus++;
                } while (n != 0);
                if (!ok)
                    Console.WriteLine("Помилка введення значення N. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            
            Console.WriteLine("Парних={0:F0}", par);
            Console.WriteLine("Непарних={0:F0}",nepar);
            Console.WriteLine("Додатніх={0:F0}", plus);
            Console.WriteLine("Від'ємних={0:F0}", minus);
        }
    }
}