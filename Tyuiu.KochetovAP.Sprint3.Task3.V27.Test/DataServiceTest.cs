using Tyuiu.KochetovAP.Sprint3.Task2.V30.Lib;

namespace Tyuiu.KochetovAP.Sprint3.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidConvertStringToInt()
        {
            DataService ds = new DataService();

            string value = "!bt, g567kid f!";
            int wait = 567;

            int result = ds.ConvertStringToInt(value);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertStringToInt_NoDigits()
        {
            DataService ds = new DataService();

            string value = "abc, def!";
            int wait = 0;

            int result = ds.ConvertStringToInt(value);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertStringToInt_OnlyDigits()
        {
            DataService ds = new DataService();

            string value = "12345";
            int wait = 12345;

            int result = ds.ConvertStringToInt(value);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertStringToInt_MixedCharacters()
        {
            DataService ds = new DataService();

            string value = "a1b2c3d4e5";
            int wait = 12345;

            int result = ds.ConvertStringToInt(value);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertStringToInt_EmptyString()
        {
            DataService ds = new DataService();

            string value = "";
            int wait = 0;

            int result = ds.ConvertStringToInt(value);

            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidConvertStringToInt_SpecialCharactersOnly()
        {
            DataService ds = new DataService();

            string value = "!@#$%^&*()";
            int wait = 0;

            int result = ds.ConvertStringToInt(value);

            Assert.AreEqual(wait, result);
        }
    }
}