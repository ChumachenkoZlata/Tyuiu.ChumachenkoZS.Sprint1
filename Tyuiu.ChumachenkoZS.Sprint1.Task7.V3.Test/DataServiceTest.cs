using Tyuiu.ChumachenkoZS.Sprint1.Task7.V3.Lib;

namespace Tyuiu.ChumachenkoZS.Sprint1.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(3.964, res);
        }
    }
}
