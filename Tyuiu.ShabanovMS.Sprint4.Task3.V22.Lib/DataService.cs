using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShabanovMS.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1; // строка
            int colums = array.Length / rows; // столбец
            int max = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (array[0, j] > max) 
                    {
                        max = array[0, j];
                    }
                }
            }
            return max;
        }
    }
}
