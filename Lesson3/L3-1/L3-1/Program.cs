using System;

namespace L3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация матрицы (двумерного массива)
            int[,] matrix;
            int sizeOfMatrix;
            Console.WriteLine("Введите размер матрицы:");
            
            // Задается размер матрицы
            sizeOfMatrix = Convert.ToInt32(Console.ReadLine());
            matrix = new int[sizeOfMatrix, sizeOfMatrix];
            
            // Матрица заполняется случайными числами от 0 до 9
            Random rnd = new Random();
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    matrix[i, j] = rnd.Next(0, 9);
                }
            }

            // Вывод исходной матрицы
            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

            // Вывод диагональных элементов
            Console.WriteLine("Элементы по диагонали:");
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    if (i == j) Console.Write($"{matrix[i, j]} \t");
                }
            }

        }
    }
}
