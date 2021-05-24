using System;

namespace L7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            float num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            float num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Сумма чисел равна: {num1 + num2}");
        }
    }
}
