using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Работает при условии, что стоит пробел после знака препинания!
            string s = "я плохо учил русский язык! забываю начинать предложения с заглавной? хорошо, что можно написать программу!";
            StringBuilder ss = new StringBuilder(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                ss.Append(s[i]);
            }
            Console.WriteLine(ss);
            ss[0] = Char.ToUpper(ss[0]);
            for (int i = 0; i < ss.Length-1; i++)
            {
                if (ss[i] == '.' || ss[i] == '!' || ss[i] == '?')
                    ss[i+2]=Char.ToUpper(ss[i + 2]);
            }
            Console.WriteLine(ss);
            Console.ReadKey();
        }
    }
}
