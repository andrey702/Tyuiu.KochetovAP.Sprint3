using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            double x = 5;

            Console.WriteLine($"Вычисление произведения ряда:");
            Console.WriteLine($"x = {x}, value = {value}, startValue = {startValue}, stopValue = {stopValue}");
            Console.WriteLine();

            for (int i = startValue; i <= stopValue; i++)
            {
                double denominator = i + value;
                double fraction = x / denominator;
                double term = Math.Pow(fraction, i);
                p *= term;

                Console.WriteLine($"i = {i}: ({x}/({i}+{value}))^{i} = ({x}/{denominator})^{i} = {term:F6}");
                Console.WriteLine($"Текущее произведение: {p:F6}");
            }

            double result = Math.Round(p, 3);
            Console.WriteLine($"Финальный результат: {result}");
            return result;
        }
    }
}
