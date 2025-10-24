using Tyuiu.GoryaevTT.Sprint4.Task6.V22.Lib;
namespace Tyuiu.GoryaevTT.Sprint4.Task6.V22
{
    class Program
    {
        public static void Main(string[] args)
        {
            Class1 ds = new Class1();
            string[] ans = new string[] { "снег", "дождь", "туман", "град", "ветер", "туча", "засуха" };
            string[] res = ds.Calculate(ans);
            Console.WriteLine(res);
        }
    }
}