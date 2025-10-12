using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task1.V29.Lib
{
    public class DataService : ISprint3Task1V29
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i = startValue;

            while (i <= stopValue)
            {
                sumSeries += (Math.Pow(value, 2) * i) + 1;
                i++;
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
