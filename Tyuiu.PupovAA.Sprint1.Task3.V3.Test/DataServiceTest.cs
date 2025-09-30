using Tyuiu.PupovAA.Sprint1.Task3.V3.Lib;
namespace Tyuiu.PupovAA.Sprint1.Task3.V3.Test_
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 9.0;
            double y = 7.5;
            double z = 5.0;
            var res = ds.ParallelepipedVolume(x , y, z);
            Assert.AreEqual(337.5, res);
        }
    }
}
