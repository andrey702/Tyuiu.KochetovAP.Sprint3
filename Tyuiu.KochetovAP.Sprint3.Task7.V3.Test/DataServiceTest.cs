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

            int start = -5;
            int stop = 5;

            double[] res = ds.GetMassFunction(start, stop);

            
            Assert.AreEqual(stop - start + 1, res.Length);

            
            double fx0 = (3 * 0 - 1.5) / (Math.Sin(0) - 3 * 0) + 2; 
            fx0 = 0; 

            Assert.AreEqual(0, res[5]); 
        }
    }
}