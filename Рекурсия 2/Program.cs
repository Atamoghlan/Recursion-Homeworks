using System;

namespace Рекурсия_и_методы_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = AskNumber();
            int num2 = AskNumber();
            Console.WriteLine($"НОД равен: {NOD(num1, num2)}");
        }
        static int AskNumber()
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
        static int NOD(int num1, int num2)
        {
            if (num2 == 0)
                return num1;
            if (num1 == 0)
                return num2;
            else
                return NOD(num2, num1 % num2);
        }
    }
}