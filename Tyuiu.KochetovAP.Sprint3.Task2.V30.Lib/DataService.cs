using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task2.V30.Lib
{
    public class DataService : ISprint3Task2V30
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int i = startValue;

            do
            {
                // Формула: (x² * i) + 2
                double term = (Math.Pow(value, 2) * i) + 2;
                multiplySeries *= term;
                i++;
            }
            while (i <= stopValue);

            return Math.Round(multiplySeries, 3);

        }
    }
}
