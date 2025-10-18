using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GoryaevTT.Sprint4.Task1.V25.Lib
{
    public class Class1 : ISprint4Task1V25
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int a in array)
            {
                if (a % 2 == 0)
                {
                    sum += a;
                }
            }
            return sum;
        }
    }
}
