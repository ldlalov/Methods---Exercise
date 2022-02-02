using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Vowels(word);
        }
        static void Vowels(string word)
        {
            //char[] word = Console.ReadLine().ToCharArray();
            int sum = 0;
            foreach (char c in word)
            {
                bool isVowel = "aeiouAEIOU".IndexOf(c) >= 0;
                if (isVowel)
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
