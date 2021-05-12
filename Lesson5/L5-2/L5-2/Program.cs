using System;
using System.IO;

namespace L5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Относительный путь на директорию с файлом "Program.cs"
            var workDir = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
            // Путь к создаваемому/дополняемому файлу "startup.txt"
            var path = Path.Combine(workDir, "startup.txt");
            // Если файл существует, то запись с переходом на новую строчку
            if (File.Exists(path) == false) File.AppendAllText(path, DateTime.Now.ToString());
            else File.AppendAllText(path, Environment.NewLine + DateTime.Now.ToString());
        }
    }
}
