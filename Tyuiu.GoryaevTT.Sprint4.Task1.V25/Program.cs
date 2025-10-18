using Tyuiu.GoryaevTT.Sprint4.Task1.V25.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task1.V25
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            int[] ar = new int[] { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };
            int res = ds.Calculate(ar);
            Console.WriteLine(res);
        }
    }
}