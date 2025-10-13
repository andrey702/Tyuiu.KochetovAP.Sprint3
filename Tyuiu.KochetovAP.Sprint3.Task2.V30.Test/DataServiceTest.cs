using Tyuiu.KochetovAP.Sprint3.Task2.V30.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double result = ds.GetMultiplySeries(value, startValue, stopValue);

            double expected = 1;
            for (int i = 1; i <= 11; i++)
            {
                expected *= (0.0625 * i + 2);
            }
            expected = Math.Round(expected, 3);

            Assert.AreEqual(expected, result);
        }
    }
}