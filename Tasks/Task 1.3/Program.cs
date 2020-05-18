using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._3
{
    /*
     Написать программу, которая запрашивает с клавиатуры число N
     и выводит на экран следующее «изображение», состоящее из N строк
      *
     ***
    *****

    */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int N = int.Parse(Console.ReadLine());
                int k = 1;
                for (int i = 1; i <= N; i++)
                {
                    
                    for (int j = N; j >= k/2+2; j--)
                    {
                        Console.Write(' ');
                    }

                    for (int j = 1; j <= k; j++)
                    {
                        Console.Write('*');
                    }
                    k += 2;
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Вы ввели не целое число");
            }
            Console.ReadKey();
        }
    }
}
