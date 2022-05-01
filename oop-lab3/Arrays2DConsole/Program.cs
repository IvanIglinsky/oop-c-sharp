using System.Text;

namespace Arrays2DConsole
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
            int n, m;
            bool ok;
            
            Console.WriteLine("Лабораторна робота №3.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4(2)\nВаріант №4.\nЗавдання 2.");
            do
            {
                Console.Write("Уведіть кількість рядків(n)= ");
                ok = int.TryParse(Console.ReadLine(), out n);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення n. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Уведіть кількість стовпців(m)=");
                ok = int.TryParse(Console.ReadLine(), out m);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення n. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            Random rnd = new Random();
            double[,] array = new double[n, m];
            Console.WriteLine("Масив:");
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {
                    array[i, j] = Convert.ToDouble(rnd.Next(-123, 163) / 10.0);
                    Console.Write($"{array[i, j]:F1}" + "     ");
                }
                Console.Write("\n");
            }
            double summ = 0, max = -999999, sumamod=0 , min=99999;
            Console.WriteLine("1)Окрема сума елементів кожного стовпця");
            for (int j = 0; j < m; j++)
            {
                summ = 0;
                for (int i = 0; i < n; i++)
                {
                    summ += array[i, j];
                }
                Console.Write($"{summ:F1}     ");
                if (summ > max)
                    max = summ;
            }
            Console.WriteLine("\n" + "Максимальна сума:");
            Console.WriteLine($"{max:F1}");
            Console.WriteLine("Сума модулів відємних елементів:");
            double[]arr=new double[m];
            for (int j = 0; j < m; j++)
            {
                sumamod = 0;
                for (int i = 0; i < n; i++)
                {
                
                    if (array[i, j] < 0)
                    {
                        sumamod += Math.Abs(array[i, j]);                      
                    }
                    arr[j] = sumamod;
                }
                Console.Write($"{arr[j]:F1}" + "    ");
                if (min > sumamod)
                    min = sumamod;
              
                for (int i = 0; i < n; i++)
                {
                 
                    for (int b = j + 1; b < m; b++)
                    {
                        if (arr[j] > arr[j+1])
                        {
                            double tmp = array[i, j];
                            array[i, j] = array[i, j + 1];
                            array[i, j + 1] = tmp;
                        }
                    }
                   
                }
               
            }             
            Console.WriteLine($"\nМінінмальна сума по модулю:{min:F1}");
            Console.WriteLine("Сортований масив за зростанням суми модулів від'ємних:");               
                for (int i = 0; i < n; i++)
                {     
                for (int j = 0; j < m; j++)
                {     
                    Console.Write($"{array[i,j]:F1}" + "    ");
                }
                Console.Write("\n");
            }
        }
    }
}
 

