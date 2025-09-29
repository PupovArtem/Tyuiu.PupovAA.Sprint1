using Tyuiu.PupovAA.Sprint1.Task2.V6.Lib;
namespace Tyuiu.PupovAA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5000;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(5, res);
        }
    }
}
