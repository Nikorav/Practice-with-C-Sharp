using System;

namespace Practice_with_multidimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] books = {
                {"Пушкин","Лермонтов","Глуховский" },
                {"Стивен Кинг","Говард Лавкрафт","Брэм Стокер" },
                {"Донцова","Ален Карр","Игорь Прокопенко" } };
            bool isOpen = true;

            while (isOpen)
            {
                Console.WriteLine("Добро пожаловать в библиотеку.");
                Console.WriteLine("\n1 - узнать что за книга, зная её индекс.\n\n2 - найти книгу по автору.\n\n3 - вывести список всех книг\n\n4 - выйти из библиотеки.\n");
                Console.Write("Введите пункт меню: ");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        Console.Write("\nВведите номер полки: ");
                        int rows = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.Write("Введите номер: ");
                        int cols = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (rows >= books.GetLength(0) || cols >= books.GetLength(1) || rows < 0 || cols < 0)
                        {
                            Console.WriteLine("Такого расположения не существует. Попробуйте ещё раз.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"\nВаша книга - {books[rows, cols]}.");
                        }
                        break;
                    case 2:
                        Console.Write("\nВведите автора книги: ");
                        string author = Console.ReadLine();
                        bool authorIsFind = false;
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (author.ToLower() == books[i, j].ToLower())
                                {
                                    Console.WriteLine($"Ваша книга на {i + 1} полке, под номером {j + 1}.\nЧто-нибудь ещё?");
                                    authorIsFind = true;
                                    break;
                                }
                            }
                        }
                        if (!authorIsFind)
                        {
                            Console.WriteLine("К сожалению, такой книги у нас нет.");
                        }                     
                        break;
                    case 3:
                        Console.WriteLine("\nСписок всех книг:");
                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                Console.WriteLine(books[i, j]);
                            }
                        }
                        break;
                    case 4:
                        isOpen = false;
                        Console.WriteLine("Всего вам хорошего, досвиданья.");
                        break;
                }

                Console.Write("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
