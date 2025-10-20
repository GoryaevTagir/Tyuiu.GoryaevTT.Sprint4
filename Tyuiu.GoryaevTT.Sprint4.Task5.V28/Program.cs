using Tyuiu.GoryaevTT.Sprint4.Task5.V28.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task5.V28
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            Random rn = new Random();
            int[,] nums = new int[,] { {rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3)}, { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) }, { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) }, { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) }, { rn.Next(-6, 3), rn.Next(-6, 3), rn.Next(-6, 3) } };
            int[,] res = ds.Calculate(nums);
            Console.WriteLine(res);
        }
    }
}