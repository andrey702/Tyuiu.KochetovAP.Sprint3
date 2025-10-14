using Tyuiu.KochetovAP.Sprint3.Task6.V6.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 16;
            int stopValue = 24;

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 11; 

            Assert.AreEqual(wait, result);
        }
    }
}
