using System;
using Tyuiu.KochetovAP.Sprint3.Task6.V6.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task6.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for                                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Кочетов А. П. | ИБКСб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
            Console.WriteLine("* числовому отрезку [16, 24] количество всех делителей больше 10          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 16;
            int stopValue = 24;

            Console.WriteLine($"Начало диапазона: {startValue}");
            Console.WriteLine($"Конец диапазона: {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine($"Количество делителей больше 10 в диапазоне [{startValue}, {stopValue}] = {result}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ПОДРОБНЫЙ РАСЧЕТ:                                                       *");
            Console.WriteLine("***************************************************************************");

            // Детальный расчет для наглядности
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.Write($"Число {x}: делители >10 = [");
                bool hasDivisors = false;
                for (int d = 11; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        Console.Write($"{d} ");
                        hasDivisors = true;
                    }
                }
                if (!hasDivisors)
                    Console.Write("нет");
                Console.WriteLine("]");
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}