using System;

namespace Practice_with_one_dimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Пример 1
            Random rand = new Random();
            int[] array = new int[10];
            int sum = 0;
            int maxElement = int.MinValue;

            for(int i = 0;i < array.Length;i++)
            {
                array[i] = rand.Next(0, 100);
                Console.WriteLine($"{array[i]} - {i} элемент");
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }

            Console.WriteLine($"Сумма всех элементов - {sum}");
            Console.WriteLine($"Максимальный элемент в массиве - {maxElement}");
            */

            int[] tables = { 5, 6, 8, 9, 1, 5, 3, 4 };
            bool isOpen = true;         
            
            while(isOpen)
            {
                Console.SetCursorPosition(0, 15);
                for (int i = 0; i < tables.Length; i++)
                {
                    Console.WriteLine($"За столом {i + 1} cвободно {tables[i]} мест.");
                }
                Console.SetCursorPosition(0, 0);

                Console.WriteLine("Администрирование кафе.");
                Console.WriteLine("\n1 - забронировать место.\n\n2 - выход из программы.");
                Console.Write("\nВведите номер команды: ");

                switch(Convert.ToInt32(Console.ReadLine()))
                {                   
                    case 1:
                        int userTable, userPlace;

                        Console.Write("За каким столом вы хотите забронировать место: ");
                        userTable = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (userTable >= tables.Length || userTable < 0)
                        {
                            Console.Write("За таким столом забронировать место невозможно.\nЧтобы попробовать ещё раз, нажмите любую клавишу.");
                            break;
                        }

                        Console.Write("Сколько мест вы хотите забронировать: ");
                        userPlace = Convert.ToInt32(Console.ReadLine());
                        if (userPlace > tables[userTable] || userPlace <= 0)
                        {
                            Console.Write("Такое количество мест забронировать невозможно.\nЧтобы попробовать ещё раз, нажмите любую клавишу.");
                            break;
                        }

                        tables[userTable] -= userPlace;
                        Console.Write("Нажмите любую клавишу для подтверждения бронирования.");

                        break;
                    case 2:
                        isOpen = false;
                        Console.Write("Всего вам хорошего.\nЧтобы выйти, нажмите любую клавишу.");
                        break;
                    default:
                        Console.Write("Такой команды нету.\nЧтобы попробовать ещё раз, нажмите любую клавишу.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
