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

            
            double expected = CalculateExpectedValue(startValue, stopValue);

            Assert.AreEqual(expected, result, 0.001);
        }

        private double CalculateExpectedValue(int start, int stop)
        {
            double sum = 0;
            for (int x = start; x <= stop; x++)
            {
                if (x == 0) break;
                sum += (Math.Cos(x) - Math.Sin(x)) / x;
            }
            return sum;
        }

        [TestMethod]
        public void ValidCalculateWithZeroStart()
        {
            DataService ds = new DataService();

            int startValue = 0;
            int stopValue = 5;

            double result = ds.Calculate(startValue, stopValue);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void ValidCalculateNegativeRange()
        {
            DataService ds = new DataService();

            int startValue = -3;
            int stopValue = -1;

            double result = ds.Calculate(startValue, stopValue);

            
            double expected = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                expected += (Math.Cos(x) - Math.Sin(x)) / x;
            }

            Assert.AreEqual(expected, result, 0.001);
        }

        [TestMethod]
        public void ValidCalculateSingleValue()
        {
            DataService ds = new DataService();

            int startValue = 2;
            int stopValue = 2;

            double result = ds.Calculate(startValue, stopValue);

            double expected = (Math.Cos(2) - Math.Sin(2)) / 2;
            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestMethod]
        public void ValidCalculateRangeWithoutZero()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 3;

            double result = ds.Calculate(startValue, stopValue);

            double expected = (Math.Cos(1) - Math.Sin(1)) / 1 +
                             (Math.Cos(2) - Math.Sin(2)) / 2 +
                             (Math.Cos(3) - Math.Sin(3)) / 3;

            Assert.AreEqual(expected, result, 0.001);
        }
    }
}