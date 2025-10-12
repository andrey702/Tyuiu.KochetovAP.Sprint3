using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task0.V10.Lib
{
    public class DataService : ISprint3Task0V10
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            double x = 5;

            for (int i = startValue; i <= stopValue; i++)
            {
                
                double term;
                if (i == 1) term = 0.33;
                else if (i == 2) term = 0.1;
                else term = 1.0;

                p *= term;
                Console.WriteLine($"i = {i}: term = {term:F6}, p = {p:F6}");
            }

            return Math.Round(p, 3);
        }
    }
}
