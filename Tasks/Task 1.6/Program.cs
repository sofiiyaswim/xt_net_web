using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._6
{
    class Program
    {
        //Метод выводит то, какие настройки шрифта выбраны в текущий момент
        static void PrintIfTrue(bool a, bool b, bool c)
        {
            if (a == true && b == true && c == true)
                Console.WriteLine("Bold, Italic, Underline");
            else if (a == true && b == true && c == false)
                Console.WriteLine("Bold, Italic");
            else if (a == true && b == false && c == true)
                Console.WriteLine("Bold, Underline");
            else if (a == true && b == false && c == false)
                Console.WriteLine("Bold");
            else if (a == false && b == true && c == true)
                Console.WriteLine("Italic, Underline");
            else if (a == false && b == true && c == false)
                Console.WriteLine("Italic");
            else if (a == false && b == false && c == true)
                Console.WriteLine("Underline");
            else
                Console.WriteLine("None");


        }
        static void Main(string[] args)
        {
            bool bold = false, italic = false, underline = false, none = true;
            Console.Write("Введите параметры надписи: ");
            PrintIfTrue(bold, italic, underline);
            while (true)
            {
                Console.WriteLine("Введите:");
                Console.WriteLine("       1: bold");
                Console.WriteLine("       2: italic");
                Console.WriteLine("       3: underline");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    if (bold == false) bold = true;
                    else bold = false;
                }
                if (a == 2)
                {
                    if (italic == false) italic = true;
                    else italic = false;
                }
                if (a == 3)
                {
                    if (underline == false) underline = true;
                    else underline = false;
                }
                Console.Write("Параметры надписи: ");
                PrintIfTrue(bold, italic, underline);
            }
            Console.ReadKey();
        }
    }
}
