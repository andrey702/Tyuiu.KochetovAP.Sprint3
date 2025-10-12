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

            // Правильный порядок параметров: value, startValue, stopValue
            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double result = ds.GetMultiplySeries(value, startValue, stopValue);

            // Ожидаемое значение: 0.033
            double wait = 0.033;

            Assert.AreEqual(wait, result);
        }
    }
}