using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._8
{
    /*Написать программу, которая заменяет все положительные элементы в трёхмерном массиве на нули. 
    Число элементов в массиве и их тип определяются разработчиком.*/
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3, type;
            while (true)
            {
                Console.Write("Введите количество элементов по 1ому индексу: "); n1 = int.Parse(Console.ReadLine());
                Console.Write("Введите количество элементов по 2ому индексу: "); n2 = int.Parse(Console.ReadLine());
                Console.Write("Введите количество элементов по 3ему индексу: "); n3 = int.Parse(Console.ReadLine());
                if (n1 < 1 || n2 < 1 || n3 < 1)
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
                int[,,] mas = new int[n1,n2,n3];
                Console.WriteLine("Исходный массив: ");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        for (int k = 0; k < n3; k++)
                        {
                            mas[i, j, k] = rnd.Next(100)-50;
                            Console.Write(mas[i,j,k]+" ");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Массив с нулями вместо положительных элементов: ");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        for (int k = 0; k < n3; k++)
                        {
                            if (mas[i, j, k] > 0) mas[i, j, k] = 0;
                            Console.Write(mas[i, j, k] + " ");
                        }
                    }
                }
            }
            if (type == 2)
            {
                double[,,] mas = new double[n1, n2, n3];
                Console.WriteLine("Исходный массив: ");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        for (int k = 0; k < n3; k++)
                        {
                            mas[i, j, k] = (rnd.Next(100) - 50)/100.0;
                            Console.Write(mas[i, j, k] + " ");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Массив с нулями вместо положительных элементов: ");
                for (int i = 0; i < n1; i++)
                {
                    for (int j = 0; j < n2; j++)
                    {
                        for (int k = 0; k < n3; k++)
                        {
                            if (mas[i, j, k] > 0) mas[i, j, k] = 0;
                            Console.Write(mas[i, j, k] + " ");
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
