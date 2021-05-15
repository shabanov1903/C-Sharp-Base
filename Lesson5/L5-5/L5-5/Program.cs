using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;

namespace L5_5
{
    class Program
    {
        // Объект класса ToDo
        private static ToDo toDo;
        static void Main(string[] args)
        {
            // Строка ввода
            string inputString;

            // Относительный путь на директорию с файлом "Program.cs"
            var workDir = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
            // Путь к создаваемому/дополняемому файлу "ToDo.json"
            var path = Path.Combine(workDir, "ToDo.json");
            // Если файл существует, инициализируем имеющиеся пункты десериализацией файла
            if (File.Exists(path) == true)
            {
                string oldJSON = File.ReadAllText(path);
                toDo = JsonSerializer.Deserialize<ToDo>(oldJSON);
            }
            else toDo = new ToDo();

            while (true)
            {
                WriteToConcole();
                inputString = Console.ReadLine();
                // Если введено число, то задание с соответствующим номером было выполнено
                try
                {
                    int numbTask = Convert.ToInt32(inputString);
                    for (int i = 0; i < toDo.completeTasks.Count; i++)
                    {
                        if (i == numbTask) toDo.completeTasks[i] = true;
                    }
                    WriteToConcole();
                }
                // Если введен набор символов, то заносим в список в качестве задания
                // Если не было введено ничего, то переходим к новому циклу
                // Если было введено "END" то сериализуем объект и завершаем программу
                catch (FormatException)
                {
                    if (inputString == "END") break;
                    if (String.IsNullOrEmpty(inputString)) continue;
                    toDo.tasks.Add(inputString);
                    toDo.completeTasks.Add(false);
                }
            }
            string newJSON = JsonSerializer.Serialize(toDo).ToString();
            File.WriteAllText(path, newJSON);
        }

        // Функция для вывода дневника на консоль
        private static void WriteToConcole()
        {
            Console.Clear();
            Console.WriteLine("Для добавления новой задачи введите её описание и нажмите ENTER");
            Console.WriteLine("Для завершения задачи введите её порядковый номер и нажмите ENTER");
            Console.WriteLine("Для выхода из приложения и сохранения параметров введите END и нажмите ENTER");
            if (toDo.completeTasks == null) return;
            int i = 0;
            foreach (bool complete in toDo.completeTasks)
            {
                if (complete) Console.WriteLine("[X]  " + (i).ToString() + " - " + toDo.tasks[i]);
                else Console.WriteLine("[ ]  " + (i).ToString() + " - " + toDo.tasks[i]);
                i++;
            }
        }
    }

    [Serializable]
    public class ToDo
    {
        public List<string> tasks { get; set; }
        public List<bool> completeTasks { get; set; }
        public ToDo ()
        {
            tasks = new List<string>();
            completeTasks = new List<bool>();
        }
    }
}
