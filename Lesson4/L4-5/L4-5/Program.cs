using System;

namespace L4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления факториала:");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Значение факториала (через рекурсию): {fFactorialReq(fNumber)}");
            Console.WriteLine($"Значение факториала (через цикл): {fFactorialRef(fNumber)}");
        }
        static int fFactorialReq(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * fFactorialReq(n - 1);
            }
        }
        static int fFactorialRef(int n)
        {
            int factorial = 1;
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= n; i++) factorial = factorial * i;
                return factorial;
            }
        }
    }
}
