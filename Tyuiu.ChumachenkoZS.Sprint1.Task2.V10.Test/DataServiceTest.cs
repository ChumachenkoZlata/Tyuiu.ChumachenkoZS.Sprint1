using Tyuiu.ChumachenkoZS.Sprint1.Task2.V10.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint1.Task2.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertMetreToInchs(x);
            Assert.AreEqual(78.74, res);
        }
    }
}
