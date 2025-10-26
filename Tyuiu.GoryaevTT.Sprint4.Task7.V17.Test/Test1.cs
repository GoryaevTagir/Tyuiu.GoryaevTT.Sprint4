using Tyuiu.GoryaevTT.Sprint4.Task7.V17.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task7.V17.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string a = "753159864";
            int res = ds.Calculate(3, 3, a);
            Assert.AreEqual(3, res);
        }
    }
}
