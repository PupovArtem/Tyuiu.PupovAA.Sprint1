using Tyuiu.PupovAA.Sprint1.Task1.V21.Lib;
namespace Tyuiu.PupovAA.Sprint1.Task1.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2.00;
            double y = 3.00;
            var res = ds.Calculate (x, y);
            Assert.AreEqual(1 ,res);
            
        }
    }
}
