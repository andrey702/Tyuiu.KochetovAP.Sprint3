using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task7.V3.Lib
{
    public class DataService : ISprint3Task7V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];
            int index = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Sin(x) - 3 + x;
                double fx;

                if (Math.Abs(denominator) < 1e-10)
                    fx = 0;
                else
                    fx = (3 * x - 1.5) / denominator + 2;

                result[index] = Math.Round(fx, 2);
                index++;
            }

            return result;

        }
    }
}
