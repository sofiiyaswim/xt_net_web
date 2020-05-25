using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1
{
    class Program
    {
        //Ответ остается в виде дробного результата
        static void Main(string[] args)
        {
            string s = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";
            char[] chars = { ' ', ',', ':' };
            string[] wordsFromS = s.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0, len;
            for (int i = 0; i<wordsFromS.Length; i++)
            {
                len = wordsFromS[i].Length;
                sum += len;
                Console.WriteLine(wordsFromS[i] + " " + len);
            }
            Console.WriteLine("Средняя длина слов в строке: " + (double)sum / wordsFromS.Length);

            Console.ReadKey();
        }
    }
}
