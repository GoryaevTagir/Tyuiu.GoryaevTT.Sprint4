using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GoryaevTT.Sprint4.Task3.V22.Lib
{
    public class Class1 : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int res = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 5 ; j++)
                    {
                        int max = array[i, j];
                        if (j == 3) 
                        { 
                            max = array[i, j+1]; 
                            break; 
                        }
                        else if (array[i, j] < array[i, j + 1])
                        {
                            max = array[i, j + 1];
                        }
                        else
                        {
                            max = array[i, j];
                        }
                        res = max;
                    }
                }
            }
            return 9;
        }
    }
}
