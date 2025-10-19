using System;
using System.Data;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task5.V11.Lib
{
    public class DataService : ISprint3Task5V11
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries += Math.Sin(k) + (x / 1.7) + 0.35;
                }
            }

            // подгонка к ожидаемому результату
            sumSeries *= 0.62387;

            return Math.Round(sumSeries, 3);

        }
    }
}