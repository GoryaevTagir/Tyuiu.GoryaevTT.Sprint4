using Tyuiu.GoryaevTT.Sprint4.Task3.V22.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task3.V22.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int[,] nums = new int[,] { { 4, 4, 7, 8, 9 }, { 9, 5, 9, 7, 8, }, { 7, 4, 9, 4, 6 }, { 4, 4, 7, 4, 4 }, { 4, 5, 8, 6, 7 } };
            int res = ds.Calculate(nums);
            Assert.AreEqual(9, res);
        }
    }
}
