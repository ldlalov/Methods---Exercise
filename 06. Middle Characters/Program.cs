using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleChar(word);
        }
        static void MiddleChar(string word)
        {
            char[] ch1 = word.ToCharArray();
            string result;
            if (ch1.Length % 2 != 0)
            {
                 result = ch1[ch1.Length / 2].ToString();
            }
            else
            {
                 result = ch1[(ch1.Length-1)/2].ToString() + ch1[(ch1.Length+1) / 2 ].ToString();
            }
            Console.WriteLine(result);
        }
    }
}
