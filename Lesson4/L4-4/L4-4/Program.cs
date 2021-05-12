using System;

namespace L4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер элемента ряда Фибоначчи:");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Значение элемента ряда (через рекурсию): {fSum(fNumber)}");

        }
        static int fSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fSum(n - 1) + fSum(n - 2);
            }
        }
    }
}
