using Tyuiu.PupovAA.Sprint1.Task7.V16.Lib;
namespace Tyuiu.PupovAA.Sprint1.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(1.022, res);
        }
    }
}
