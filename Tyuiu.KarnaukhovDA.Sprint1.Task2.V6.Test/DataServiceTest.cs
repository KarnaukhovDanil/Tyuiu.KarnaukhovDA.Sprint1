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
            int meters = 6;
            double result = ds.ConvertMToKm(meters);
            Assert.AreEqual(0.006 , result, 0.000001);
        }
    }
}
