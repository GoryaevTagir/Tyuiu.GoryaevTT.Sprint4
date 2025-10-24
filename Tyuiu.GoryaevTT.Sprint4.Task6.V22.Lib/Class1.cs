using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GoryaevTT.Sprint4.Task6.V22.Lib
{
    public class Class1 : ISprint4Task6V22
    {
        public string[] Calculate(string[] array)
        {
            string[] res = Array.FindAll(array, week => week.Length == 4);
            return res;
        }
    }
}
