using Tyuiu.GoryaevTT.Sprint4.Task0.V2.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task0.V2.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int[] ar = new int[] { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            int res = ds.GetSumOddArrEl(ar);
            Assert.AreEqual(44, res);
        }
    }
}
