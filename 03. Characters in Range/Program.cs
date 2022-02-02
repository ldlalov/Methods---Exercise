using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            CharInRange(ch1, ch2);
        }
        static void CharInRange(char ch1, char ch2)
        {
            if (ch2 > ch1)
            {
                for (int i = ch1 + 1; i < ch2; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = ch2+1; i < ch1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
