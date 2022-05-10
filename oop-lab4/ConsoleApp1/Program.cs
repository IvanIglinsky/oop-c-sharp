using System.Text;

namespace StructConsole
{
    public class Program
    {
        public struct Product
        {
            public string Name;
            public struct Currency
            {
                public double Cost;
                public string Name;
                public double ExRate;
            }
            public int Quantity;
            public string Producer;
            public double Weigh;
            public double GetPriceInUAH(Product.Currency[] Prices, int n)
            {
                double UAH = 0;
                for (int i = 0; i < n; i++)
                    UAH = Prices[i].Cost * Prices[i].ExRate;
                return UAH;
            }
            public double GetTotalPriceInUAH(Product[] prods, Product.Currency[] Prices, int n)
            {
                double TotalPrice = 0;
                for (int i = 0; i < n; i++)
                    TotalPrice = Prices[i].Cost * Prices[i].ExRate * prods[i].Quantity;
                return TotalPrice;
            }
            public double GetTotalWeight(Product[] prods, int n)
            {
                double TotalWeight = 0;
                for (int i = 0; i < n; i++)
                    TotalWeight = prods[i].Weigh * prods[i].Quantity;
                return TotalWeight;
            }
           

        }
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                       System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Лабораторна робота №4.\nВиконав: Іглінський І.Ю., група ІПЗ-21-4(2)\nВаріант №4.\nЗавдання 1.");
            Console.Title = "Лабораторна робота №4";
            Console.SetWindowSize(100, 25);
            Console.Write("Уведіть кількість структур n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 0, menu = 0, yesNo = 0;
            double max = 0, mini = 0;
            bool end = true;
            Product[] prods = new Product[n * 4];
            Product.Currency[] Prices = new Product.Currency[n * 3];

            Console.WriteLine("Масив структур:");
            ReadProductsArray(n, i, prods, Prices);
            do
            {
                Console.Clear();
                Console.WriteLine("Виберіть пункт меню:");
                Console.WriteLine("1-Виведення масиву");
                Console.WriteLine("2-Найдорожчий та найдешевший товар");
                Console.WriteLine("3-Ціна товару в гривнях");
                Console.WriteLine("4-Загальна вартість усіх товарів");
                Console.WriteLine("5-Загальна вага");
                Console.WriteLine("6-Сортований масив за зростанням цін");
                Console.WriteLine("7-Сортований масив за кількістю товарів");
                Console.WriteLine("8-Вийти з меню");
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                switch (menu)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        PrintProducts(n, prods, Prices);
                        break;
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            GetProductsInfo(n, Prices, out mini, out max);
                            Console.WriteLine("Найдорожчий:{0}", max);
                            Console.WriteLine("Найдешевший:{0}", mini);
                        }
                        break;
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("Ціна товару в гривнях:");
                            Console.WriteLine(prods[i].GetPriceInUAH(Prices, n));
                        }
                        break;
                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("Загальна вартість усіх товарів:");
                            Console.WriteLine(prods[i].GetTotalPriceInUAH(prods, Prices, n));
                        }
                        break;
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Загальна вага:");
                            Console.WriteLine(prods[i].GetTotalWeight(prods, n));
                        }
                        break;
                    case 6:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Сортований масив за зростанням цін:");
                            SortProductsByPrice(n, ref Prices, ref prods);

                        }
                        break;
                    case 7:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Сортований масив за кількістю товарів:");
                            SortProductsByCount(ref prods, ref Prices, n);

                        }
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

        static void ReadProductsArray(int n, int i, Product[] prods, Product.Currency[] Prices)
        {
            for (i = 0; i < n; i++)
            {
                Console.Write("Назва товару:");
                prods[i].Name = Console.ReadLine().ToString();
                Console.Write("Назва валюти:");
                Prices[i].Name = Console.ReadLine().ToString();
                Console.Write("Вартість товару:");
                Prices[i].Cost = Convert.ToDouble(Console.ReadLine().ToString());
                Console.Write("Курс:");
                Prices[i].ExRate = Convert.ToDouble(Console.ReadLine().ToString());
                Console.Write("Кількість наявних товарів на складі:");
                prods[i].Quantity = Convert.ToInt32(Console.ReadLine().ToString());
                Console.Write("Назва компанії-виробника:");
                prods[i].Producer = Console.ReadLine().ToString();
                Console.Write("Вага одиниці товару:");
                prods[i].Weigh = Convert.ToDouble(Console.ReadLine().ToString());
                Console.WriteLine("----------------------------------");

            }
        }
        static void PrintProduct(int n, Product[] prods, Product.Currency[] Prices)
        {
            n = 2;
            PrintProducts(n, prods, Prices);

        }
        static void PrintProducts(int n, Product[] prods, Product.Currency[] Prices)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Виведення структури:");
                Console.WriteLine($"Назва товару:{prods[i].Name}");
                Console.WriteLine($"Назва валюти:{Prices[i].Name}");
                Console.WriteLine($"Вартість товару:{Prices[i].Cost}");
                Console.WriteLine($"Курс:{Prices[i].ExRate}");
                Console.WriteLine($"Кількість наявних товарів на складі:{prods[i].Quantity}");
                Console.WriteLine($"Назва компанії-виробника:{prods[i].Producer}");
                Console.WriteLine($"Вага одиниці товару:{prods[i].Weigh}");
                Console.WriteLine("----------------------------------");
            }
        }

        public static void GetProductsInfo(int n, Product.Currency[] Prices, out double mini, out double max)
        {
            max = -9999999; mini = 9999999;
            for (int i = 0; i < n; i++)
            {
                if (Prices[i].Cost > max)
                    max = Prices[i].Cost;
                if (Prices[i].Cost < mini)
                    mini = Prices[i].Cost;
            }
        }
        public static int GetProductsInfoSort(Product.Currency x, Product.Currency y)
        {           
                if ( x.Cost > y.Cost)
                    return 1;
                if (x.Cost < y.Cost)
                    return -1;            
            return 0;
        }
        
        public static void SortProductsByPrice(int n,ref Product.Currency[] Prices, ref Product[]prods)
        {
            Array.Sort(Prices, GetProductsInfoSort);
            PrintProducts(n, prods, Prices);
        }
        private static int GetProductsCount(Product x, Product y)
        {
            double n = 2;
            for (int i = 0; i < n; i++)
            {
                if (x.Quantity > y.Quantity)
                    return 1;
                if (x.Quantity < y.Quantity)
                    return -1;
            }
            return 0;
        }
        public static void SortProductsByCount( ref Product[] prods, ref Product.Currency[] Prices,int n)
        {
            Array.Sort(prods,GetProductsCount);
            PrintProducts(n, prods, Prices);
        }
    }
}  