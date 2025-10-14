using System;
using Tyuiu.KochetovAP.Sprint3.Task5.V11.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumSumSeries()
        {
            // Arrange
            DataService ds = new DataService();

            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;

            // Act
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Ожидаемый результат вычислен заранее (по формуле задачи)
            double expected = 64.234;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}