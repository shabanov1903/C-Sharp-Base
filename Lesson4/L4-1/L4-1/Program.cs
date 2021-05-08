using System;

namespace L4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] fullName = new string[4, 3];
            fullName[0, 0] = "Абросимов";   fullName[0, 1] = "Виктор";      fullName[0, 2] = "Витальевич";
            fullName[1, 0] = "Сельков";     fullName[1, 1] = "Алексей";     fullName[1, 2] = "Семёнович";
            fullName[2, 0] = "Балыбердин";  fullName[2, 1] = "Владимир";    fullName[2, 2] = "Борисвич";
            fullName[3, 0] = "Семёнов";     fullName[3, 1] = "Сергей";      fullName[3, 2] = "Геннадьевич";

            for (int i = 0; i < fullName.GetLength(0); i++)
            {
                Console.WriteLine($"Имя пользователя {i + 1}:");
                Console.WriteLine(GetFullName(fullName[i, 0], fullName[i, 1], fullName[i, 2]));
            }
        }

        private static string GetFullName (string firstName, string secondName, string lastName)
        {
            return String.Join(" ", firstName, secondName, lastName);
        }
    }
}
