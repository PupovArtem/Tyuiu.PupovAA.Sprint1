using Tyuiu.PupovAA.Sprint1.Task5.V5.Lib;
namespace Tyuiu.PupovAA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Double x = 32.597;
            var res = ds.Calculate(x);
            Assert.AreEqual(5, res);
        }
    }
}
