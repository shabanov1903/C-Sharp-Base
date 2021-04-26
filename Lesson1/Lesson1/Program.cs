using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Приветсвтенная строка программы
            Console.WriteLine("Введите имя и нажмите Enter");
            // Ожидание ввода имени пользователя
            var Name = Console.ReadLine();
            // Вывод шаблона строки с текущей датой (без времени)
            Console.WriteLine($"Привет, {Name}, сегодня {DateTime.Now.ToShortDateString()}!");
        }
    }
}
