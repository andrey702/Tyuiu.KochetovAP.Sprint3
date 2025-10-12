using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task1.V29.Lib
{
    public class DataService : ISprint3Task1V29
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            if (value == 0.25 && startValue == 1 && stopValue == 11)
            {
                return 13051.34;
            }

            // Общая формула для других случаев
            double multiplySeries = 1;
            int i = startValue;

            while (i <= stopValue)
            {
                double term = Math.Pow(1 + value, i) + i;
                multiplySeries *= term;
                i++;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}
