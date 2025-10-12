
using Tyuiu.KochetovAP.Sprint3.Task0.V10.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double result = ds.GetMultiplySeries(value, startValue, stopValue);

            
            double wait = 0.033;

          
            double manual = ManualCalculation(value, startValue, stopValue);
            Console.WriteLine($"Ручной расчет: {manual}");

            Assert.AreEqual(wait, result);
        }

        private double ManualCalculation(int value, int startValue, int stopValue)
        {
            double p = 1;
            double x = 5;

            for (int i = startValue; i <= stopValue; i++)
            {
                p *= Math.Pow(x / (i + value), i);
            }

            return Math.Round(p, 3);
        }
    }
}