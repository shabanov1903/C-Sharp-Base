using System;

namespace L2_2
{
    class Program
    {
        // Enum для определения месяцев
        enum Year : byte
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца в диапазоне 1..12");
            byte numMonth = Convert.ToByte(Console.ReadLine());
            // Проверка введённого месяца
            switch (numMonth)
            {
                case (byte)Year.January:    Console.WriteLine("Январь"); break;
                case (byte)Year.February:   Console.WriteLine("Февраль"); break;
                case (byte)Year.March:      Console.WriteLine("Март"); break;
                case (byte)Year.April:      Console.WriteLine("Апрель"); break;
                case (byte)Year.May:        Console.WriteLine("Май"); break;
                case (byte)Year.June:       Console.WriteLine("Июнь"); break;
                case (byte)Year.July:       Console.WriteLine("Июль"); break;
                case (byte)Year.August:     Console.WriteLine("Август"); break;
                case (byte)Year.September:  Console.WriteLine("Сентябрь"); break;
                case (byte)Year.October:    Console.WriteLine("Октябрь"); break;
                case (byte)Year.November:   Console.WriteLine("Ноябрь"); break;
                case (byte)Year.December:   Console.WriteLine("Декабрь"); break;
                default:                    Console.WriteLine("Ошибка"); break;
            }
            
        }
    }
}
