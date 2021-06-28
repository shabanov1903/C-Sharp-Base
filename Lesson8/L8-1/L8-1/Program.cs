using System;

namespace L8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings1.Default.Hello);
            if (string.IsNullOrEmpty(Properties.Settings1.Default.Name) == false)
            {
                Console.WriteLine($"Имя предыдущего пользователя: {Properties.Settings1.Default.Name}");
            }
            if (string.IsNullOrEmpty(Properties.Settings1.Default.Age) == false)
            {
                Console.WriteLine($"Возраст предыдущего пользователя: {Properties.Settings1.Default.Age}");
            }
            if (string.IsNullOrEmpty(Properties.Settings1.Default.Job) == false)
            {
                Console.WriteLine($"Профессия предыдущего пользователя: {Properties.Settings1.Default.Job}");
            }
            Console.WriteLine("Введите имя пользователя, которое отобразится при следующем входе в приложение:");
            Properties.Settings1.Default.Name = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя, который отобразится при следующем входе в приложение:");
            Properties.Settings1.Default.Age = Console.ReadLine();
            Console.WriteLine("Введите профессию пользователя, которая отобразится при следующем входе в приложение:");
            Properties.Settings1.Default.Job = Console.ReadLine();
            Properties.Settings1.Default.Save();
        }
    }
}