using Tyuiu.GoryaevTT.Sprint4.Task2.V4.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task2.V4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rn = new Random();
            Class1 ds = new Class1();
            int[] nums = new int[13];
            foreach (int i in nums)
            {
                nums[i] = rn.Next(2, 9);
            }
            int res = ds.Calculate(nums);
            Console.WriteLine(res);
        }
    }
}