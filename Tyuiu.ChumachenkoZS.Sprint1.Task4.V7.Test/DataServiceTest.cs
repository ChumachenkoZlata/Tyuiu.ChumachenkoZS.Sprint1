using Tyuiu.ChumachenkoZS.Sprint1.Task4.V7.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint1.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.323, res);
        }
    }
}
