using Tyuiu.KochetovAP.Sprint3.Task5.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            // arrange
            var service = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            // act
            double result = service.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // assert
            double expected = 64.234;
            Assert.AreEqual(expected, result, 0.01, "результат суммы серии неверный");
        }
    }
}
