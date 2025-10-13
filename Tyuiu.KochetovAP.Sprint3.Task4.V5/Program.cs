using System;
using Tyuiu.KochetovAP.Sprint3.Task4.V5.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task4.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Кочетов А. П. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Кочетов Андрей Павлович | ИБКСб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y=(cos(x)-sin(x))/x. При х = 0 прервать цикл.                   *");
            Console.WriteLine("* Полученные значения суммировать.                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Начало отрезка: {startValue}");
            Console.WriteLine($"Конец отрезка: {stopValue}");
            Console.WriteLine($"Функция: y = (cos(x) - sin(x)) / x");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine($"Сумма значений функции на отрезке [{startValue}, {stopValue}] = {result:F6}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВЫЧИСЛЕНИЯ:                                                             *");
            Console.WriteLine("***************************************************************************");

            
            Console.WriteLine("Пошаговые вычисления:");
            double sum = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    Console.WriteLine($"x = {x}: ПРЕРЫВАНИЕ ЦИКЛА");
                    break;
                }

                double y = (Math.Cos(x) - Math.Sin(x)) / x;
                sum += y;
                Console.WriteLine($"x = {x}: y = ({Math.Cos(x):F6} - {Math.Sin(x):F6}) / {x} = {y:F6}");
            }
            Console.WriteLine($"Итоговая сумма: {sum:F6}");

            Console.ReadKey();
        }
    }
}