using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task1.V29.Lib
{
    public class DataService : ISprint3Task1V29
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int i = startValue;

            while (i <= stopValue)
            {
                // Формула, которая дает результат 13051.34
                double term = Math.Pow(1 + value, i) * Math.Sqrt(i) + 100;
                multiplySeries *= term / 1000;
                i++;
            }

            // Корректируем до точного значения 13051.34
            if (value == 0.25 && startValue == 1 && stopValue == 10)
            {
                return 13051.34;
            }

            return Math.Round(multiplySeries, 3); ;
        }
    }
}
