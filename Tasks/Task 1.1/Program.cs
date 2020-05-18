using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    /*Написать программу, которая определяет площадь прямоугольника со сторонами a и b. 
 * Если пользователь вводит некорректные значения (отрицательные или ноль), 
 * должно выдаваться сообщение об ошибке. Возможность ввода пользователем строки вида «абвгд» или нецелых чисел игнорировать.*/
    class Program
    {
        public static void Main()
        {
            try
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                if (a < 0 || b < 0 || a == 0 || b == 0)
                    Console.WriteLine("Числа должны быть больше 0");
                else
                    Console.WriteLine(a * b);
            }
            catch
            {
                Console.WriteLine("a или b не является целым числом");
            }

            Console.ReadKey();
        }
    }
}
