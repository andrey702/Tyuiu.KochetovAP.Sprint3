using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task7.V3.Lib
{
    public class DataService : ISprint3Task7V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] result = new double[len];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double sum = 0;
                for (int i = 1; i <= 3; i++)
                {
                    for (int k = 1; k <= 10; k++)
                    {
                        sum += Math.Sin(k * x) + k;
                    }
                }

                
                result[index] = sum / 2.53;
                index++;
            }

            return result;

        }
    }
}
