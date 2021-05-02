using System;

namespace L2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            string TITLE = "Кассовый чек";
            string inn = "005401362078";
            string nm = "20412939";
            string kl = "2393";

            int art1 = 75;
            float cost1 = 7260;

            int art2 = 260;
            float cost2 = 10500;

            float total;
            float cash;
            float surrend;

            string pfp = "00000108";

            // Расчет суммарной стоимости
            total = cost1 + cost2;
            // Внесено денег
            cash = 20000;
            // Сдача
            surrend = cash - total;

            Console.WriteLine(TITLE);
            Console.WriteLine("ИНН:\t"+inn);
            Console.WriteLine("НМ:\t"+nm);
            Console.WriteLine("КЛ:\t"+kl);
            Console.WriteLine("Дата:\t"+Convert.ToString(DateTime.Now));
            Console.WriteLine("----------------------------");
            Console.WriteLine("Артикул\tСтоимость");
            Console.WriteLine(Convert.ToString(art1)+"\t"+ Convert.ToString(cost1));
            Console.WriteLine(Convert.ToString(art2)+"\t"+ Convert.ToString(cost2));
            Console.WriteLine("----------------------------");
            Console.WriteLine("ИТОГО:\t" + total);
            Console.WriteLine("ПРИХОД:\t" + cash);
            Console.WriteLine("СДАЧА:\t" + surrend);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Спасибо за покупку!");
            Console.WriteLine("ПФП:\t" + pfp);
        }
    }
}
