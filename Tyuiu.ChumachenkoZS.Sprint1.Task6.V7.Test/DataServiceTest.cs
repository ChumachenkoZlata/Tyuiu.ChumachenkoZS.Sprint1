using Tyuiu.ChumachenkoZS.Sprint1.Task6.V7.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strTest = "дом цветок яблоко";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strTest);
            Assert.AreEqual("до цвето яблок", res);
        }
    }
}
