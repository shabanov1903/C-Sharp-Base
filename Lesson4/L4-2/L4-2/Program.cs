using System;
using System.Collections.Generic;

namespace L4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Лист строк (для удобства масштабируемого массива)
            List<string> elements = new List<string>();

            // Входная строка
            string inputString;

            // Сумма введенных чисел
            int summ = 0;

            Console.WriteLine("Введите ряд чисел через пробел и нажмите ENTER:");
            inputString = Console.ReadLine();

            // Фиксация индекса пробела в строке
            int last = 0;

            // Фиксация первого цикла поиска пробела
            bool firstStep = true;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ')
                {
                    if (firstStep)
                    {
                        elements.Add(inputString.Substring(last, i - last));
                        last = i;
                        firstStep = false;
                    }
                    else
                    {
                        elements.Add(inputString.Substring(last + 1, i - last));
                        last = i;
                    }
                }
            }
            elements.Add(inputString.Substring(last + 1));

            // Операция суммирования
            foreach (string i in elements)
            {
                summ = summ + Convert.ToInt32(i);
            }

            // Вывод результата
            Console.WriteLine($"Сумма равна: {summ}");
        }
    }
}