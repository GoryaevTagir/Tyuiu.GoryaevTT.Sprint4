using Tyuiu.GoryaevTT.Sprint4.Task4.V5.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task4.V5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            int[,] nums = new int[,] { { 6, 3, 6, 6, 7 }, { 9, 8, 9, 7, 9 }, { 5, 6, 8, 7, 5 }, { 8, 5, 6, 5, 3 }, { 3, 9, 9, 8, 8, } };
            int ans = ds.Calculate(nums);
            Console.WriteLine(ans);
        }
    }
}