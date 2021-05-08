using System;

namespace L4_3
{
    class Program
    {
        enum Year
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        // Переменная-индикатор ошибки
        static bool error = true;
        static void Main(string[] args)
        {
            // Номер месяца
            int number;
            
            // Цикл будет предлагать ввести номер месяца, пока он не будет введён корректно
            while (error)
            {
                Console.WriteLine("Введите порядковый номер месяца:");
                number = Int32.Parse(Console.ReadLine());
                // Вызов функции и запись в переменную соответствующего emun
                Year year = Season(number);
                if (error)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12:");
                }
                else
                {
                    // Вывод на консоль времени года и завершение программы
                    Console.WriteLine("Время года:");
                    Console.WriteLine(SeasonDetect(year));
                }
            }
        }

        private static Year Season (int number)
        {
            // В случае удачного завершения программы флаг останется в значении false
            error = false;
            switch (number)
            {
                case 1: return Year.Winter;
                case 2: return Year.Winter;
                case 3: return Year.Spring;
                case 4: return Year.Spring;
                case 5: return Year.Spring;
                case 6: return Year.Summer;
                case 7: return Year.Summer;
                case 8: return Year.Summer;
                case 9: return Year.Autumn;
                case 10: return Year.Autumn;
                case 11: return Year.Autumn;
                case 12: return Year.Winter;
            }
            // При правильно введённом значении месяца программа не дойдёт до этого места 
            error = true;
            // Дефолтное значение (не используется в программе)
            return Year.Winter;
        }
        private static string SeasonDetect(Year year)
        {
            switch (year)
            {
                case Year.Winter: return "Зима";
                case Year.Spring: return "Весна";
                case Year.Summer: return "Лето";
                case Year.Autumn: return "Осень";
                // Дефолтное значение (не используется в программе)
                default: return "";
            }
        }
    }
}
