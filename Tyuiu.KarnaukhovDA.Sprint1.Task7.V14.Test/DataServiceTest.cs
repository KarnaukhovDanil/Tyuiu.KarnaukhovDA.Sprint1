using Tyuiu.KarnaukhovDA.Sprint1.Task7.V14.Lib;

namespace Tyuiu.KarnaukhovDA.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double wait = -0.889;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
