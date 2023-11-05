using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabanovMS.Sprint4.Task3.V22.Lib;
namespace Tyuiu.ShabanovMS.Sprint4.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шабанов М.С. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("*Выполнил: Шабанов Мирон Сергеевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов найти максимальный  *");
            Console.WriteLine("* элемент первой строки                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            int[,] array = new int[5,5] {
                { 4, 4, 7, 8, 9 },
                { 9, 5, 9, 7, 8 },
                { 7, 4, 9, 4, 6 },
                { 4, 4, 7, 4, 4 },
                { 4, 5, 8, 6, 7 } };

            int rows = array.GetUpperBound(0) + 1; 
            int colums = array.Length / rows;
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            
            int res = ds.Calculate(array);
            Console.WriteLine("Наибольший элемент первой строки = " + res);

            Console.ReadKey();
        }
    }
}
