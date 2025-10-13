using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KochetovAP.Sprint3.Task4.V5.Lib;
using System;

namespace Tyuiu.KochetovAP.Sprint3.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);

            double expected = -0.858;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}