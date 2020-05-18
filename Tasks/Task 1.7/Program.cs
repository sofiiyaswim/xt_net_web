using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._7
{
    class Program
    {
        static int[] MasOfIntegerNumbers(int N)
        {
            Random rnd = new Random();
            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = rnd.Next(-1000, 1000);
            }
            return mas;
        }
        static double[] MasOfDoubleNumbers(int N)
        {
            Random rnd = new Random();
            double[] mas = new double[N];
            for (int i = 0; i < N; i++)
            {
                int x = rnd.Next(0,2);
                if (x == 0)
                    mas[i] = rnd.NextDouble()*(-1000.00);
                else
                    mas[i] = rnd.NextDouble() * 1000.00;

            }
            return mas;
        }
        static char[] MasOfCharNumbers(int N)
        {
            Random rnd = new Random();
            char[] mas = new char[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = (char)rnd.Next(0x0410, 0x44F);
            }
            return mas;
        }
        static string[] MasOfStringNumbers(int N)
        {
            Random rnd = new Random();
            string[] mas = new string[N];
            for (int i = 0; i < N; i++)
            {
                int x = rnd.Next(1, 10);
                for (int j = 0; j <x; j++)
                {
                    mas[i] = mas[i]+(char)rnd.Next(0x0410, 0x44F);
                }
            }
            return mas;
        }

        static void PrintMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }
        static void PrintMas(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0:0.00} ", mas[i]);
            }
            Console.WriteLine();
        }
        static void PrintMas(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine();
        }
        static void PrintMas(string[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write("{0} ", mas[i]);
            }
            Console.WriteLine();
        }


        static int[] SortMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int b = mas[j]; 
                        mas[j] = mas[j + 1]; 
                        mas[j + 1] = b;
                    }
                }
            }
            return mas;
        }
        static double[] SortMas(double[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        double b = mas[j]; 
                        mas[j] = mas[j + 1];
                        mas[j + 1] = b; 
                    }
                }
            }
            return mas;
        }
        static char[] SortMas(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        char b = mas[j]; 
                        mas[j] = mas[j + 1];
                        mas[j + 1] = b; 
                    }
                }
            }
            return mas;
        }
        static string[] SortMas(string[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 1; j++)
                {
                    if (mas[j].Length > mas[j + 1].Length)
                    {
                        string b = mas[j]; 
                        mas[j] = mas[j + 1]; 
                        mas[j + 1] = b; 
                    }
                }
            }
            return mas;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Чем будут являться элементы массива?");
            Console.WriteLine("     1 - целые числа \n     2 - вещественные числа \n     3 - символы \n     4 - строки");
            int typeMas = int.Parse(Console.ReadLine());
            Console.Write("Введите количество элементов массива: ");
            int N = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            if (typeMas == 1)
            {
                int[] mas = new int[N];
                mas = MasOfIntegerNumbers(N);
                Console.WriteLine("Исходный массив:");
                PrintMas(mas);
                mas = SortMas(mas);
                Console.WriteLine("Отсортированный массив:");
                PrintMas(mas);
                int maxValue = mas[N - 1];
                Console.WriteLine("Максимальный элемент массива: " + maxValue);
                int minValue = mas[0];
                Console.WriteLine("Минимальный элемент массива: " + minValue);
            }
            else if (typeMas == 2)
            {
                double[] mas = new double[N];
                mas = MasOfDoubleNumbers(N);
                Console.WriteLine("Исходный массив:");
                PrintMas(mas);
                mas = SortMas(mas);
                Console.WriteLine("Отсортированный массив:");
                PrintMas(mas);
                double maxValue = mas[N - 1];
                Console.WriteLine("Максимальный элемент массива: " + maxValue);
                double minValue = mas[0];
                Console.WriteLine("Минимальный элемент массива: " + minValue);
            }
            else if (typeMas == 3)
            {
                char[] mas = new char[N];
                mas = MasOfCharNumbers(N);
                Console.WriteLine("Исходный массив:");
                PrintMas(mas);
                mas = SortMas(mas);
                Console.WriteLine("Отсортированный массив (по таблице символов):");
                PrintMas(mas);
                char maxValue = mas[N - 1];
                Console.WriteLine("Максимальный элемент массива: " + maxValue);
                char minValue = mas[0];
                Console.WriteLine("Минимальный элемент массива: " + minValue);
            }
            else
            {
                string[] mas = new string[N];
                mas = MasOfStringNumbers(N);
                Console.WriteLine("Исходный массив:");
                PrintMas(mas);
                mas = SortMas(mas);
                Console.WriteLine("Отсортированный массив (по количеству символов):");
                PrintMas(mas);
                string maxValue = mas[N - 1];
                Console.WriteLine("Максимальный элемент массива: " + maxValue);
                string minValue = mas[0];
                Console.WriteLine("Минимальный элемент массива: " + minValue);
            }

            Console.ReadLine();
        }
    }
}
