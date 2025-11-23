using Tyuiu.KarnaukhovDA.Sprint1.Task6.V8.Lib;
namespace Tyuiu.KarnaukhovDA.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет Мир";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd( strTest );
            string wait = "риветП ирМ";
            Assert.AreEqual( wait, res );
        }
    }
}
