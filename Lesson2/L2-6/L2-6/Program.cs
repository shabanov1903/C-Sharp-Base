using System;

namespace L2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Маска расписания для офиса: 0 бит - понедельник ... 7 бит - воскресенье
            // 1 - рабочий день, 0 - выходной
            byte office1 = 0b00011110;
            byte office2 = 0b01111111;
            Console.WriteLine("Расписание работы офиса 1:");
            writeWeek(office1);
            Console.WriteLine("Расписание работы офиса 2:");
            writeWeek(office2);
        }

        // Функция writeWeek служит для отображения расписания в консоли
        // и передачи параметра check в функцию checkDay
        private static void writeWeek(byte office)
        {
            byte check = 0b00000001;
            Console.WriteLine("Понедельник - " + checkDay(office, check));
            check = (byte)(check << 1);
            Console.WriteLine("Вторник - " + checkDay(office, check));
            check = (byte)(check << 1);
            Console.WriteLine("Среда - " + checkDay(office, check));
            check = (byte)(check << 1);
            Console.WriteLine("Четверг - " + checkDay(office, check));
            check = (byte)(check << 1);
            Console.WriteLine("Пятница - " + checkDay(office, check));
            check = (byte)(check << 1);
            Console.WriteLine("Суббота - " + checkDay(office, check));
            check = (byte)(check << 1);
            Console.WriteLine("Воскресенье - " + checkDay(office, check));
        }

        // Функция checkDay проверяет значение бита в соответствии с dayMask
        // и в случае положительного результата на выход отправляется строка "Рабочий день"
        private static string checkDay(byte office, byte dayMask)
        {
            if ((office & dayMask) == dayMask) return "Рабочий день";
            else return "Выходной";
        }
    }
}
