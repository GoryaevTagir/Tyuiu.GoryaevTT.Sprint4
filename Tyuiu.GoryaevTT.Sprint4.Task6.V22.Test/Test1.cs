using Tyuiu.GoryaevTT.Sprint4.Task6.V22.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task6.V22.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            string[] ans = new string[] { "снег", "дождь", "туман", "град", "ветер", "туча", "засуха" };
            string[] res = ds.Calculate(ans);
            Assert.AreEqual(3, res.Length);
        }
    }
}
