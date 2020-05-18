﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._5
{
    /*
     Если выписать все натуральные числа меньше 10, кратные 3 или 5, то получим 3, 5, 6 и 9. 
     Сумма этих чисел будет равна 23. Напишите программу, которая выводит на экран 
     сумму всех чисел меньше 1000, кратных 3 или 5. 
    */
    class Program
    {
        //Проверка числа на кратность 3 или 5
        static bool IsMultipleNum(int a)
        {
            if (a % 3 == 0 || a % 5 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (IsMultipleNum(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
