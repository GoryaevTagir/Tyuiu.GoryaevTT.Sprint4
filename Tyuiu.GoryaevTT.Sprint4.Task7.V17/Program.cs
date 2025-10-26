using Tyuiu.GoryaevTT.Sprint4.Task7.V17.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task7.V17
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            string a = "753159864";
            int res = ds.Calculate(3, 3, a);
            Console.WriteLine(res);
        }
    }
}