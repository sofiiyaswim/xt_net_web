using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "написать программу, которая";
            string s2 = "описание";
            StringBuilder s3 = new StringBuilder(100);
            int j = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s2.Contains(s1[i]))
                {
                    //Console.WriteLine("good");
                    s3.Append(s1[i]);
                    s3.Append(s1[i]);
                }
                else 
                {
                    s3.Append(s1[i]);

                }
            }
            Console.WriteLine(s3);
            Console.ReadLine();
        }
    }
}
