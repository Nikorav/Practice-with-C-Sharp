using System;

namespace Practice_with_conditional_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Пример 1
            string password = "scp-001";
            string userInput;

            Console.Write("Введите пароль:");
            userInput = Console.ReadLine();

            if(userInput == password)
            {
                Console.WriteLine("Информация о процедуре 110-монтаук");
            }
            else
            {
                Console.WriteLine("Летальный мамегент запущен");
            }
            */

            float rub;
            float usd;
            int rubToUsd = 64, usdToRub = 66;
            string userInput;
            float currencyCount;

            Console.WriteLine("Добро пожаловать в обменник валют. У нас вы можете  обменять рубли в доллары и доллары в рубли.");
            Console.Write("Введите баланс рублей:");
            rub = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите баланс долларов:");
            usd = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("1 - обменять рубли на доллары");
            Console.WriteLine("2 - обменять доллары в рубли");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Обмен рублей на доллары.");
                    Console.Write("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if(rub >= currencyCount)
                    {
                        rub -= currencyCount;
                        usd += currencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недопутимое количество рублей!");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмен долларов на рубли.");
                    Console.Write("Сколько вы хотите обменять:");
                    currencyCount = Convert.ToSingle(Console.ReadLine());
                    if (usd >= currencyCount)
                    {
                        usd -= currencyCount;
                        rub += currencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недопутимое количество долларов");
                    }
                    break;
            }
            Console.WriteLine($"Ваш баланс - {rub} рублей и {usd} долларов");
        }
    }
}
