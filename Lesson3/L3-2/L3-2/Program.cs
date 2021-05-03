using System;

namespace L3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация справочника
            string[,] directory = new string[5,2];
            directory[0, 0] = "Абросимов";
            directory[1, 0] = "Баранов";
            directory[2, 0] = "Ваганов";
            directory[3, 0] = "Григорьев";
            directory[4, 0] = "Дружинин";
            directory[0, 1] = "+7 (921) 997-48-51";
            directory[1, 1] = "+7 (996) 447-11-22";
            directory[2, 1] = "+7 (999) 124-98-36";
            directory[3, 1] = "+7 (911) 555-50-74";
            directory[4, 1] = "+7 (931) 754-49-03";
            
            // Поиск абонента по его фамилии
            Console.WriteLine("Введите фамилию абонента для поиска:");
            string secondName;
            secondName = Console.ReadLine();

            // Флаг проверки успешного поиска
            bool checkAbonent = false;
            for (int i = 0; i < directory.GetLength(0); i++)
            {
                if (directory[i, 0] == secondName)
                {
                    Console.WriteLine($"Абонент с фамилией {directory[i, 0]} имеет номер:");
                    Console.WriteLine($"{directory[i, 1]}");
                    checkAbonent = true;
                    break;
                }
            }
            if (checkAbonent == false) Console.WriteLine($"Абонент с фамилией {secondName} не найден");
        }
    }
}