using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ShabanovMS.Sprint4.Task2.V11.Lib
{
    public class DataService : ISprint4Task2V11
    {
        public int Calculate(int[] array)
        {
            int result = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 1)
                {
                    result = result + array[i];
                }
            }
            return result;
        }
    }
}
