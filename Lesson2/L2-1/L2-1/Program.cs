using System;

namespace L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальную температуру за сутки в формате xx.x");
            string strTMax = Console.ReadLine();
            // Фильтр для ввода символа точки
            strTMax = strTMax.Replace('.', ',');
            // Приведение типа
            float tMax = Convert.ToSingle(strTMax);
            Console.WriteLine("Введите минимальную температуру за сутки в формате xx.x");
            string strTMin = Console.ReadLine();
            // Фильтр для ввода символа точки
            strTMin = strTMin.Replace('.', ',');
            // Приведение типа
            float tMin = Convert.ToSingle(strTMin);
            // Расчёт среднего значения и вывод в консоль
            float tMiddle = (tMax + tMin) / 2;
            Console.WriteLine(tMiddle);
        }
    }
}
