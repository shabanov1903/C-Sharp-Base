using System;
using System.IO;
using System.Collections.Generic;

namespace L5_4
{
    /*
     Задача выполнена с использованием следующего ресурса:
     https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/file-system/how-to-iterate-through-a-directory-tree
     */
    class Program
    {
        // Относительный путь на директорию с файлом "Program.cs"
        static string workDir;
        // Путь к создаваемому/дополняемому файлу "directoriesRec.txt"
        static string path1;
        // Путь к создаваемому/дополняемому файлу "directoriesNotRec.txt"
        static string path2;

        static void Main()
        {
            workDir = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
            path1 = Path.Combine(workDir, "directoriesRec.txt");
            path2 = Path.Combine(workDir, "directoriesNotRec.txt");

            System.IO.DirectoryInfo rootDir = new System.IO.DirectoryInfo(workDir);
            WalkDirectoryTree(rootDir);
            // К моменту вызова функции TraverseTree() файл "directoriesRec.txt" уже существует
            TraverseTree(rootDir.ToString());
        }

        static void WalkDirectoryTree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            // Получение всех файлов в директории
            try
            {
                files = root.GetFiles("*.*");
            }
            // В случае ошибки доступа вывести в консоль сообщение
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            // В случае отсутствия директории вывести в консоль сообщение
            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            if (files != null)
            {
                // Последовательный перебор всех файлов в директории и запись в файл "directoriesRec.txt"
                foreach (System.IO.FileInfo fi in files)
                {
                    if (File.Exists(path1) == false) File.AppendAllText(path1, fi.FullName);
                    else File.AppendAllText(path1, Environment.NewLine + fi.FullName);
                }

                // После записи всех названий файлов получаем имя всех дочерних директорий
                subDirs = root.GetDirectories();

                // Рекурсивно делаем операции переборв файлов и директорий с записью в файл
                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    WalkDirectoryTree(dirInfo);
                }
            }
        }


        public static void TraverseTree(string root)
        {
            // Глубина стека 20 строк
            Stack<string> dirs = new Stack<string>(20);

            // Проверка существования директории и вызов исключения в случае её отсутствия
            if (!System.IO.Directory.Exists(root))
            {
                throw new ArgumentException();
            }

            // Внесение основной директории в стек
            dirs.Push(root);

            // Цикл по директориям и занесение в файл "directoriesNotRec.txt" дерева через стек
            while (dirs.Count > 0)
            {
                // Присваивание переменной currentDir значения верхней переменной стека (в первом цикле - корень запроса)
                string currentDir = dirs.Pop();
                // Инициализация массива subDir дочерними директориями
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDir);
                }
                // Ошибка доступа
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                // Отсутствие директории
                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                // Инициализация массива files файлами из текущей директории
                string[] files = null;
                try
                {
                    files = System.IO.Directory.GetFiles(currentDir);
                }
                // Ошибка доступа
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                // Отсутствие директории
                catch (System.IO.DirectoryNotFoundException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                // Последовательный перебор всех файлов в директории и запись в файл "directoriesNotRec.txt"
                foreach (string file in files)
                {
                    try
                    {
                        if (File.Exists(path2) == false) File.AppendAllText(path2, file);
                        else File.AppendAllText(path2, Environment.NewLine + file);
                    }
                    // Файл не найден
                    catch (System.IO.FileNotFoundException e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
                // Добавление дочерних директорий (относительно текущей директории) в стек и вызов в следующем цикле
                foreach (string str in subDirs)
                    dirs.Push(str);
            }
        }

    }
}