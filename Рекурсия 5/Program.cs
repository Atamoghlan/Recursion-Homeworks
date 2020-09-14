using System;

namespace Рекурсия_и_методы_5
{
    public enum Days : int
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }
    class Program
    {
        static int AskDay()
        {
            int a;
            while (true)
            {
                Console.WriteLine("Введите число");
                bool test = int.TryParse(Console.ReadLine(), out a);
                if (test == false)
                {
                    Console.WriteLine("Ошибка! Введите число");
                }
                else
                    return a;

            }
        }
        static void Main()
        {
            int Answer = AskDay();
            {
                if (Answer == 1)
                { Console.WriteLine(Days.Monday); }
                else if (Answer == 2)
                { Console.WriteLine(Days.Tuesday); }
                else if (Answer == 3)
                { Console.WriteLine(Days.Wednesday); }
                else if (Answer == 4)
                { Console.WriteLine(Days.Thursday); }
                else if (Answer == 5)
                { Console.WriteLine(Days.Friday); }
                else if (Answer == 6)
                { Console.WriteLine(Days.Saturday); }
                else if (Answer == 7)
                { Console.WriteLine(Days.Sunday); }
                else
                    Console.WriteLine("Такого дня недели пока не существует");
            }
        }
    }
}