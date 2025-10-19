using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint3.Task5.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            var service = new DataService();
            double result = service.GetSumSumSeries(5, 1, 1, 3, 10);
            double expected = 64.234;

            Assert.AreEqual(expected, result, 0.0, "результат суммы серии неверный");
        }
    }
}