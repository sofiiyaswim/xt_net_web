using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._9
{
    class Program
    {
        /*Написать программу, которая определяет сумму неотрицательных элементов в одномерном массиве. 
        Число элементов в массиве и их тип определяются разработчиком.*/
        static void Main(string[] args)
        {
            int n,type;
            while (true)
            {
                Console.Write("Введите количество элементов массива: "); n = int.Parse(Console.ReadLine());
                if (n < 1)
                    Console.WriteLine("Количество не может быть меньше единицы");
                else
                    break;
            }
            while (true)
            {
                Console.WriteLine("Укажите тип элементов массива: 1 - целые, 2 - вещественные");
                type = int.Parse(Console.ReadLine());
                if (type == 1 || type == 2)
                    break;
                else
                    Console.WriteLine("Укажите допустимый тип элементов (1 или 2)");
            }
            Random rnd = new Random();
            if (type == 1)
            {
                int[] mas = new int[n];
                Console.WriteLine("Исходный массив: ");
                for (int i = 0; i < n; i++)
                {
                    mas[i] = rnd.Next(100) - 50;
                    Console.Write(mas[i] + " ");
                }
                int sum = 0;
                Console.WriteLine();
                for (int i = 0; i < n;i++)
                {
                    if (mas[i] > 0) sum += mas[i];
                }
                Console.WriteLine("Сумма неотрицательных элементов: "+sum);
            }
            if (type == 2)
            {
                double[] mas = new double[n];
                Console.WriteLine("Исходный массив: ");
                for (int i = 0; i < n; i++)
                {
                    mas[i] = (rnd.Next(100) - 50)/100.0;
                    Console.Write(mas[i] + " ");
                }
                double sum = 0;
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    if (mas[i] > 0) sum += mas[i];
                }
                Console.WriteLine("Сумма неотрицательных элементов: " + sum);
            }
            Console.ReadLine();
        }
    }
}
