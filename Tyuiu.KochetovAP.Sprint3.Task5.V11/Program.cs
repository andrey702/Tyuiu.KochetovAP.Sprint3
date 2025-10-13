using System;
using Tyuiu.KochetovAP.Sprint3.Task5.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Кочетов Андрей Павлович | ИБКСб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму сумм ряда с использованием *");
            Console.WriteLine("* вложенных циклов по формуле: y = x/2 + Σ(i=1..3) Σ(k=1..10) sin(k)     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт шага первой суммы ряда = {startValue1}");
            Console.WriteLine($"Конец шага первой суммы ряда = {stopValue1}");
            Console.WriteLine($"Старт шага второй суммы ряда = {startValue2}");
            Console.WriteLine($"Конец шага второй суммы ряда = {stopValue2}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Console.WriteLine($"Результат = {result}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВЫЧИСЛЕНИЯ:                                                             *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Пошаговые вычисления:");
            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                Console.WriteLine($"i = {i}:");
                double innerSum = 0;

                for (int k = startValue2; k <= stopValue2; k++)
                {
                    double sinValue = Math.Sin(k);
                    innerSum += sinValue;
                    Console.WriteLine($"  k = {k}: sin({k}) = {sinValue:F6}");
                }

                totalSum += innerSum;
                Console.WriteLine($"  Сумма для i={i}: {innerSum:F6}");
                Console.WriteLine();
            }

            Console.WriteLine($"Общая сумма синусов: {totalSum:F6}");
            Console.WriteLine($"x/2 = {x}/2 = {x / 2.0:F6}");
            Console.WriteLine($"Итоговая сумма: {totalSum:F6} + {x / 2.0:F6} = {totalSum + x / 2.0:F6}");
            Console.WriteLine($"Округленный результат: {Math.Round(totalSum + x / 2.0, 3)}");

            Console.ReadKey();
        }
    }
}