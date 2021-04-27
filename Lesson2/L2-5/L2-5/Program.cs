using System;

namespace L2_5
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
            // Переменная для определения зимнего периода
            bool monthCheck = false;

            Console.WriteLine("Введите максимальную температуру за сутки в формате xx.x");
            string strTMax = Console.ReadLine();
            // Фильтр для ввода символа точки
            strTMax = strTMax.Replace('.', ',');
            // Приведение типа
            float tMax = Convert.ToSingle(strTMax);
            Console.WriteLine("Введите минимальную температуру за сутки в формате xx.x");
            string strTMin = Console.ReadLine();
            // Фильтр для ввода символа точки
            strTMin = strTMin.Replace('.', ',');
            // Приведение типа
            float tMin = Convert.ToSingle(strTMin);
            // Расчёт среднего значения и вывод в консоль
            float tMiddle = (tMax + tMin) / 2;

            Console.WriteLine("Введите порядковый номер месяца в диапазоне 1..12");
            byte numMonth = Convert.ToByte(Console.ReadLine());
            // Проверка введённого месяца
            switch (numMonth)
            {
                case (byte)Year.January: { Console.WriteLine("Январь"); monthCheck = true; } ; break;
                case (byte)Year.February: { Console.WriteLine("Февраль"); monthCheck = true; }; break;
                case (byte)Year.March: Console.WriteLine("Март"); break;
                case (byte)Year.April: Console.WriteLine("Апрель"); break;
                case (byte)Year.May: Console.WriteLine("Май"); break;
                case (byte)Year.June: Console.WriteLine("Июнь"); break;
                case (byte)Year.July: Console.WriteLine("Июль"); break;
                case (byte)Year.August: Console.WriteLine("Август"); break;
                case (byte)Year.September: Console.WriteLine("Сентябрь"); break;
                case (byte)Year.October: Console.WriteLine("Октябрь"); break;
                case (byte)Year.November: Console.WriteLine("Ноябрь"); break;
                case (byte)Year.December: { Console.WriteLine("Декабрь"); monthCheck = true; }; break;
                default: Console.WriteLine("Ошибка ввода номера месяца. Перезапустите приложение"); return;
            }

            Console.WriteLine("Средняя температура: " + tMiddle);

            if ((tMiddle>0) && (monthCheck==true))
            {
                Console.WriteLine("Дождливая зима");
            }
        }
    }
}
