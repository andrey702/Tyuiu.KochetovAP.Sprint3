using System;
using Tyuiu.KochetovAP.Sprint3.Task7.V3.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Циклы. Табулирование функции                                      *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Кочетов А. П. | ИБКСб-25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (3x - 1.5) / (sin(x) - 3x) + 2                                   *");
            Console.WriteLine("* Выполнить табулирование на диапазоне [-5; 5] с шагом 1.                 *");
            Console.WriteLine("* Проверить деление на ноль. При делении на ноль вернуть 0.               *");
            Console.WriteLine("* Результат округлить до двух знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double[] values = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("   x\t\tF(x)");
            Console.WriteLine("-----------------------------");

            int x = startValue;
            foreach (double fx in values)
            {
                Console.WriteLine($"{x,4}\t\t{fx,6}");
                x++;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Программа завершена. Нажмите любую клавишу для выхода.                  *");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}