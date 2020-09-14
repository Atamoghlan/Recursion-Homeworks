using System;

namespace Рекурсия_и_методы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 10;
            Console.WriteLine(Summ(s));
            Console.ReadKey();
        }
        static double Summ(double s)
        {
            double p = Pow(s);
            if (s == 2)
                return 4;
            else
                return p + Summ(s - 1);
        }
        static double Pow(double s)
        {
            int p = 1;
            for (int i = 1; i <= s; i++)
            {
                p *= 2;
            }
            return p;
        }
    }
}
