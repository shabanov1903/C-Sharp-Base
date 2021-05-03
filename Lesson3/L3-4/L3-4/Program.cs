using System;

namespace L3_4
{
    class Program
    {
        static char[,] matrix = new char[10, 10];
        static void Main(string[] args)
        {
            // Расстановка кораблей по заданным координанам
            ship4(1, 2);
            ship3(6, 2);
            ship3(3, 6);
            ship2(4, 1);
            ship2(7, 5);
            ship2(9, 7);
            ship1(9, 0);
            ship1(9, 4);
            ship1(0, 9);
            ship1(3, 9);

            // Вывод матрицы и дозаполнение символами 'O'
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 'X') matrix[i, j] = 'O';
                    Console.Write($"{matrix[i, j]}   ");
                }
                Console.WriteLine();
            }
        }

        // Установка четырехпалубного корабля горизонтально
        static void ship4(int x, int y)
        {
            for (int i = 0; i < 4; i++)
            {
                matrix[x, i + y] = 'X';
            }
        }

        // Установка трехпалубного корабля вертикально
        static void ship3(int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                matrix[i + x, y] = 'X';
            }
        }

        // Установка двуххпалубного корабля горизонтально
        static void ship2(int x, int y)
        {
            for (int i = 0; i < 2; i++)
            {
                matrix[x, i + y] = 'X';
            }
        }

        // Установка однопалубного корабля
        static void ship1(int x, int y)
        {
            matrix[x, y] = 'X';
        }
    }
}