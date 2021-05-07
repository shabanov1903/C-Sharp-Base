using System;

namespace L3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пременная для запоминания элемента n-2
            int fSumma1 = 0;
            // Пременная для запоминания элемента n-1
            int fSumma2 = 0;
            Console.WriteLine("Введите порядковый номер элемента ряда Фибоначчи:");
            int fNumber = Convert.ToInt32(Console.ReadLine());
            // Если пользователь ввёл число больше 0, то задаются начальные условия
            if (fNumber > 0) fSumma2 = 1;
            for (int i = 0; i < fNumber; i++)
            {
                fSumma2 = fSumma1 + fSumma2;
                // В случае нулевой итерации fSumma1 должна остаться нулевой
                if (i != 0) fSumma1 = fSumma2 - fSumma1;
            }
            Console.WriteLine($"Значение элемента ряда (через цикл): {fSumma2}");
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
