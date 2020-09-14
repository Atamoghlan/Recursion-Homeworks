using System;

namespace Рекурсия_и_методы_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            double s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ответ:  {Func(s, n)}");
            Console.ReadKey();
        }
        static double Func(double s, double n)// n=3 s=-2
        {
            double q = s;
            if (q == 0)
                return 1;
            else if (q == 1)
                return n;
            else if (q < 0)
                return 1 / n * Func(q + 1, n);
            else
                return n * Func(q - 1, n);
        }
    }
}