using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GoryaevTT.Sprint4.Task0.V2.Lib
{
    public class Class1 : ISprint4Task0V2
    {
        public int GetSumOddArrEl(int[] array)
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
