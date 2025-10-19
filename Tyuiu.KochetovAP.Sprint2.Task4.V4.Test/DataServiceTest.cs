using Tyuiu.KochetovAP.Sprint2.Task4.V4.Lib;

namespace Tyuiu.KochetovAP.Sprint2.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            int a = 175;
            int b = 176;
            int c = 414;
            int d = 414;

            bool[] res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { false, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}