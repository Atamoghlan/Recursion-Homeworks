using System;

namespace Рекурсия_и_методы_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальное число");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальное число");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Ответ:  {sum(min + 1, max - 1)}");
            Console.ReadKey();
        }
        static int sum(int min, int max)
        {

            if (min == max)
                return min;
            else
                return max + sum(min, max - 1);
        }

    }
}