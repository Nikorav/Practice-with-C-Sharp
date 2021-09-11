using System;

namespace PracticeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример первый:");

            float health;
            int armor;
            int damage;

            Console.Write("Введите количество жизней:");
            health = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество брони:");
            armor = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество урона:");
            damage = Convert.ToInt32(Console.ReadLine());

            health -= Convert.ToSingle(damage) / 100 * armor;

            Console.WriteLine($"Посли акати в {damage} урона, у вас осталось {health} жизней.");

            //////////////////////////

            Console.WriteLine("Пример второй");

            int money;
            int eatCount;
            int eatPrice = 10;
            bool enoughMoney;

            Console.WriteLine($"Добро пожаловать в пекарню! Сегодня еда по {eatPrice} монет");
            Console.Write("Сколько у вас золота:");
            money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько еды вам нужно:");
            eatCount = Convert.ToInt32(Console.ReadLine());

            enoughMoney = money >= eatCount * eatPrice;
            eatCount *= Convert.ToInt32(enoughMoney);
            money -= eatCount * eatPrice;

            Console.WriteLine($"У вас в сумке - {eatCount} еды и {money} монет.");
        }
    }
}
