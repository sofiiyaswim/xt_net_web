using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант без *
            Console.WriteLine("Вариант без *");
            string s = "Антон выпил кофе и послушал Стинга";
            char []var1 = { ' ' };
            string[] s2 = s.Split(var1, StringSplitOptions.None);
            int sum = 0;
            for (int i = 0; i < s2.Length; i++)
            {
                if (Char.IsLower(s2[i][0]))
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine();
            Console.WriteLine("Вариант со *");
            string s3 = "Антон хорошо начал., утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";
            char[] var2 = { ',', ':','.', ' ' };
            string[] s4 = s3.Split(var2, StringSplitOptions.None);
            sum = 0;
            for (int i = 0; i < s4.Length; i++)
            {
                if (s4[i] != "")
                {
                    if (Char.IsLower(s4[i][0]))
                    {
                        sum++;
                    }
                }
            }
            Console.WriteLine(sum);


            Console.ReadKey();
        }
    }
}
