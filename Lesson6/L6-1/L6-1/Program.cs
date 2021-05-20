using System;
using System.Diagnostics;
using System.ComponentModel;

namespace L6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Process[] processes = Process.GetProcesses();
                Console.WriteLine("Перечень процессов в системе:");
                Console.WriteLine("ID" + "\t" + "Name");
                Console.WriteLine("======" + "\t" + "======");
                // Вывод всех запущенных процессов в системе (ID и Имя)
                foreach (Process pr in processes)
                {
                    Console.WriteLine(pr.Id + "\t" + pr.ProcessName);
                }
                Console.WriteLine("Для завершения процесса введите его ID или Name и нажмите ENTER");
                Console.WriteLine("Для выхода из программы введите END и нажмите ENTER");
                // Ввод строки и её анализ
                var inputString = Console.ReadLine();
                if (inputString == "END") break;
                if (String.IsNullOrEmpty(inputString)) continue;
                foreach (Process pr in processes)
                {
                    // Если введенная строка совпадает с одним из имён процессов, то завершаем его, проверяя на то, не является ли он системным
                    if (pr.ProcessName == inputString)
                    {
                        try
                        {
                            pr.Kill(); continue;
                        }
                        catch (Win32Exception)
                        {
                            Console.WriteLine("Выбранный процесс является системным. Отказано в завершении. Для продолжения нажмите любую клавишу.");
                            Console.ReadLine();
                        }                        
                    }
                    // Если введенная строка совпадает с одним из ID процессов, то завершаем его, проверяя на то, не является ли он системным
                    int ID;
                    if ((Int32.TryParse(inputString, out ID) == true) && (pr.Id == ID))
                    {
                        try
                        {
                            pr.Kill(); continue;
                        }
                        catch (Win32Exception)
                        {
                            Console.WriteLine("Выбранный процесс является системным. Отказано в завершении. Для продолжения нажмите любую клавишу.");
                            Console.ReadLine();
                        }
                    }
                }
            }
            
        }
    }
}
