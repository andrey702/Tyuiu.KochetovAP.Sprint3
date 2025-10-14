using System;
using Tyuiu.KochetovAP.Sprint3.Task5.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Задание #5 | Вариант 11 | Кочетов А.П.";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Кочетов А.П. | ИБКСб-25-1                                     *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = 5;
            double result = ds.GetSumSumSeries(x, 1, 1, 3, 10);

            Console.WriteLine($"Результат вычислений: y = {result}");
            Console.ReadKey();
        }
    }
}