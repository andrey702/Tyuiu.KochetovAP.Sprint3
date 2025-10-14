using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KochetovAP.Sprint3.Task6.V6.Lib
{
    public class DataService : ISprint3Task6V6
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalCount = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                int countForX = 0;
                for (int d = 11; d <= x; d++) 
                {
                    if (x % d == 0)
                    {
                        countForX++;
                    }
                }
                totalCount += countForX;
            }

            return totalCount;
        }
    }
}
