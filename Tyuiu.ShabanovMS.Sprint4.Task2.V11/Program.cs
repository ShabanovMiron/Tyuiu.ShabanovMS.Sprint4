using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShabanovMS.Sprint4.Task2.V11.Lib;
namespace Tyuiu.ShabanovMS.Sprint4.Task2.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Шабанов М.С. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт 4                                                                *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("*Выполнил: Шабанов Мирон Сергеевич | АСОиУб-23-1                          *");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 3 до 8 подсчитать сумму четных элементов      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            Random rnd = new Random();


            int length;
            Console.WriteLine("Введите кол-во элементов массива: ");
            length = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[length];


            for(int i = 0; i <= length - 1; i++)
            {
                array[i] = rnd.Next(3, 8);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= length - 1; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");


            int result = ds.Calculate(array);
            Console.WriteLine("Сумма четных элементов массива: " + result);
            Console.ReadKey();
        }
    }
}
