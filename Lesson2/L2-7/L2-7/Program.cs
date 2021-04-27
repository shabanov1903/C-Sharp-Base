using System;

namespace L2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число:");
            string strInput = Console.ReadLine();
            Console.WriteLine("Решение с использованием строк:");
            // Выводим символы строки с последнего по нулевой в одну строчку
            for (int i = strInput.Length; i > 0; i--)
            {
                Console.Write(strInput[i-1]);
            }
            // Перевод строки
            Console.WriteLine();
            long intInput = Convert.ToInt64(strInput);
            long intOutput = 0;
            // Циклическая обработка введенного числа через остаток от деления на 10
            while (intInput != 0)
            {
                intOutput = intOutput * 10 + intInput % 10;
                intInput /= 10;
            }
            Console.WriteLine("Решение через преобразование в число:");
            Console.WriteLine(intOutput);
        }
    }
}
