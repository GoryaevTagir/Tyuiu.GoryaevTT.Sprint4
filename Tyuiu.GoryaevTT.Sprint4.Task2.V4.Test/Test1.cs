using Tyuiu.GoryaevTT.Sprint4.Task2.V4.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task2.V4.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int[] ar = new int[] { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };
            int res = ds.Calculate(ar);
            Assert.AreEqual(42, res);
        }
    }
}
