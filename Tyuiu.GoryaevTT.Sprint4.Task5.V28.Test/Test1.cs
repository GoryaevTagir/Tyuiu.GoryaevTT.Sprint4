using Tyuiu.GoryaevTT.Sprint4.Task5.V28.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task5.V28.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            Random rn = new Random();
            int[,] nums = new int[,] { { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) }, { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) }, { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) }, { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) }, { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) } };
            int[,] res = ds.Calculate(nums);
            Assert.AreEqual(res, res);
        }
    }
}
