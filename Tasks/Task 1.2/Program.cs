using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    /*
     Написать программу, которая запрашивает с клавиатуры число N и выводит 
     на экран следующее «изображение», состоящее из N строк:
     *
     **
     ***      
    */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int N = int.Parse(Console.ReadLine());
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write('*');
                    }
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
