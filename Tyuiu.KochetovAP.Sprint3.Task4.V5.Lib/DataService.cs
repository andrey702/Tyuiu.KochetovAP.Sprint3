using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task4.V5.Lib
{
    public class DataService : ISprint3Task4V5
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                
                if (x == 0)
                {
                    break;
                }

                
                double y = (Math.Cos(x) - Math.Sin(x)) / x;
                sum += y;
            }

            return sum;
        }
    }
}
