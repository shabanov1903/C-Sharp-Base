using System;
using System.IO;

namespace L5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Относительный путь на директорию с файлом "Program.cs"
            var workDir = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
            Console.WriteLine("Введите любой текст и нажмите ENTER. Сохранённый текст можно найти по следующему пути:");
            Console.WriteLine(workDir);
            var inputText = Console.ReadLine();
            // Путь к создаваемому файлу "L5_1_Text.txt"
            var path = Path.Combine(workDir, "L5_1_Text.txt");
            // Создание и запись в файл "L5_1_Text.txt"
            File.WriteAllText(path, inputText);
        }
    }
}
