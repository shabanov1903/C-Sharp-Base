using System;

namespace L2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целочисленное значение для проверки на четность");
            string strNumb = Console.ReadLine();
            // Проверка на корректность ввода чисел
            if (strNumb.Contains('.') || strNumb.Contains(','))
            {
                Console.WriteLine("Введено число с плавающей точкой. Проверка на четность будет некорректна");
                return;
            }
            int numb = Convert.ToInt32(strNumb);
            // Проверка по остатку деления
            if (numb % 2 == 0)
            {
                Console.WriteLine($"Введённое число {numb} является чётным");
            }
            else
            {
                Console.WriteLine($"Введённое число {numb} является нечётным");
            }
        }
    }
}
