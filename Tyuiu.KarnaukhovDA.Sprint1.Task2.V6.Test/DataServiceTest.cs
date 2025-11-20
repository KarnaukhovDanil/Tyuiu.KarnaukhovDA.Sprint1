using Tyuiu.KarnaukhovDA.Sprint1.Task2.V6.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1000; //метров
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(1.000, res);
        }
    }
}
