﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.GoryaevTT.Sprint4.Task5.V28.Lib
{
    public class Class1 : ISprint4Task5V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        string n = Convert.ToString(matrix[i, j]);
                        Convert.ToInt32(n.Replace(n, "0"));

                    }
                }
            }
            return matrix;
        }
    }
}
