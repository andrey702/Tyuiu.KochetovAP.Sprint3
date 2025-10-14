using System;
using Tyuiu.KochetovAP.Sprint3.Task7.V3.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMassFunction()
        {
            
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            
            double[] res = ds.GetMassFunction(startValue, stopValue);

            
            double[] expected = { 4.34, 4.16, 3.71, 3.27, 2.93, 2.5, 0.71, -47.61, 55.15, 45.17, 14.97 };

            
            Assert.AreEqual(expected.Length, res.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], res[i], 0.01, $"Ошибка в индексе {i}");
            }
        }
    }
}