namespace ClassLibrary1
{
    public class Fraction
    {
         int num;
         int den;
        bool ok;
        public Fraction(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Знаменик не може бути нулем...", nameof(y));
            }
            num = x;
            den = y;
        }

        public static Fraction operator +(Fraction a) => a;

        public static Fraction operator -(Fraction a) => new Fraction(-a.num, a.den);

        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);

        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);

        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.num * b.num, a.den * b.den);

        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }
        public static bool operator <(Fraction a, Fraction b)
        {
            a.ok = a.num * b.den < a.den * b.num;
            return a.ok;

        }
        public static bool operator >(Fraction a, Fraction b)
        {
            a.ok = a.num * b.den > a.den * b.num;
            return a.ok;
        }
        public static bool operator >=(Fraction a, Fraction b)
        {
            return a.ok = a.num * b.den >= a.den * b.num;
        }
        public static bool operator <=(Fraction a, Fraction b)
        {
            return a.ok = a.num * b.den <= a.den * b.num;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.ok = a.num * b.den == a.den * b.num;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.ok = a.num * b.den != a.den * b.num;
        }
        public override string ToString() => $"{num} / {den}";
        public static void Cut(Fraction a)
        {
            double res = ToDouble(a);

            Console.WriteLine($"{1:F}",res);
        }
        public static double ToDouble(Fraction a)
        {
            double res = (double)a.num / a.den;
            return res;
        }
       
        
    }
}