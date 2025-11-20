using Tyuiu.KarnaukhovDA.Sprint1.Task3.V13.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 13;
            
            double wait = 169;
            var res = ds.MultiplyOfDigits(number);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
