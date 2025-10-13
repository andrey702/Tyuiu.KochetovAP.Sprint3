using Tyuiu.KochetovAP.Sprint3.Task5.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 6.734; 
            Assert.AreEqual(wait, result);
        }
    }
    
}