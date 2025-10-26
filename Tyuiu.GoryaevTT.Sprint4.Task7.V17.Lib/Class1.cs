using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GoryaevTT.Sprint4.Task7.V17.Lib
{
    public class Class1 : ISprint4Task7V17
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;
            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(value[i * n + j].ToString());
                    if (mat[i,j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
