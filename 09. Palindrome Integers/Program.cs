using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Palindrome(input);
                input = Console.ReadLine(); 
            }
        }
        static void Palindrome(string input)
        {
            bool isPalindrome = true;
            char[] chars = input.ToCharArray();
            char[] newchars = chars.Reverse().ToArray();
            for (int i = 0; i < chars.Length; i++)
            {
            if (newchars[i]!=chars[i])
            {
                isPalindrome = false;
                    break;
            }
            }
            Console.WriteLine(isPalindrome);
        }
    }
}
