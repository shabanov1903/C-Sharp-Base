using System;

namespace L3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод строки
            Console.WriteLine("Введите строку:");
            string strInput = Console.ReadLine();
            // Выводим символы строки с последнего по нулевой в одну строчку
            Console.WriteLine("Символы строки в обратном порядке:");
            for (int i = strInput.Length; i > 0; i--)
            {
                Console.Write(strInput[i - 1]);
            }
        }
    }
}
