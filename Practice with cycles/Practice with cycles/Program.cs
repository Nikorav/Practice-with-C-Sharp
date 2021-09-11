using System;

namespace Practice_with_cycles
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Пример 1
            int tryCount = 5;
            string password = "123456";
            string userInput;

            for(int i = 0;i < tryCount;i++)
            {
                Console.Write("Введите пароль:");
                userInput = Console.ReadLine();
                if (password == userInput)
                {
                    Console.Write("Секретики!");
                    break;
                }
                else
                {
                    Console.WriteLine($"У вас осталось - {tryCount - i - 1} попыток");
                }
            }
            */

            /*
            // Пример 2
            float money;
            int years;
            int percent;

            Console.Write("Введите количество денег внесённых на вклад:");
            money = Convert.ToSingle(Console.ReadLine());
            Console.Write("На сколько лет открыт вклад:");
            years = Convert.ToInt32(Console.ReadLine());
            Console.Write("Под какой процент:");
            percent = Convert.ToInt32(Console.ReadLine());

            for(int i = 0;i < years;i++)
            {
                money += money / 100 * percent;
                Console.WriteLine($"В этом году у вас - {money}");
                Console.ReadKey();
            }
            */

            int health = 90;
            int damage = 5;
            int enemyHealth = 50;
            int enemyDamage = 10;

            while(health > 0 && enemyHealth > 0)
            {
                health -= enemyDamage;
                enemyHealth -= damage;
                Console.WriteLine($"{health} - герой.");                
                Console.WriteLine($"{enemyHealth} - соперник.");
            }

            if(health <= 0 && enemyHealth <= 0)
            {
                Console.WriteLine("Ничья.");
            }
            else if (health <= 0)
            {
                Console.WriteLine("Победа соперника!");
            } 
            else
            {               
                Console.WriteLine("Победа героя!");
            } 
        }
    }
}
