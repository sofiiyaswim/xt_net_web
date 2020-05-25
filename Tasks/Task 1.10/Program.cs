using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._10
{
    class Program
    {
        /*Элемент двумерного массива считается стоящим на чётной позиции, если сумма номеров его позиций 
         по обеим размерностям является чётным числом (например, [1,1] — чётная позиция, а [1,2] — нет). 
         Определить сумму элементов массива, стоящих на чётных позициях.
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 5;//Размерность массива
            int[,] mas = new int[n, n];
            Console.WriteLine("Исходный массив (индексация с нуля): ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mas[i, j] = rnd.Next(50);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(mas[i, j]);
                        sum += mas[i, j];
                    }
                    if ((i + 1) * (j + 1) != n * n)
                        Console.Write(" + ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма элементов на четных позициях: " + sum);
            Console.ReadKey();
        }
    }
}
