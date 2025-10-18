using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GoryaevTT.Sprint4.Task2.V4.Lib
{
    public class Class1 : ISprint4Task2V4
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int a in array)
            {
                if (a % 2 != 0)
                {
                    sum += a;
                }
            }
            return sum;
        }
    }
}
