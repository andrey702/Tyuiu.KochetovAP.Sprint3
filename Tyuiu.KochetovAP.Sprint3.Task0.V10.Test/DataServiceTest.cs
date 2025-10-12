using System;
using Tyuiu.KochetovAP.Sprint3.Task0.V10.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();

            double result = ds.GetMultiplySeries(5, 1, 5);

            double expected = 1.0;
            for (int i = 1; i <= 5; i++)
            {
                expected *= Math.Pow((i + 5) / 300.0, i); 
            }

            expected = Math.Round(expected, 3);
            Assert.AreEqual(expected, result);
        }
    }
}