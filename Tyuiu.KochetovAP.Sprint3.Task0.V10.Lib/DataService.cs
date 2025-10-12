using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {

            double p = 1;

            for (int i = startValue; i <= stopValue; i++)
            {
                p *= Math.Pow(300.0 / (i + value), i);
            }

            return Math.Round(p, 3);


        }
    }
}
