using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if (DivisibleBy8(i)==true && Odd(i)==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static bool DivisibleBy8(int num)
        {
            int input = num;
            int sum = 0;
            bool isDivisibleBy8 = false;
                while (num > 0)
                {
                    int digit = num % 10;
                    sum += digit;
                    num /= 10;
                }
                if (sum % 8 == 0)
                {
                isDivisibleBy8 = true;
                return isDivisibleBy8;
                }
                return isDivisibleBy8;
        }
        static bool Odd(int num)
        {
            bool hasOdd = false;
            int input = num;
                while (num > 0)
                {
                    int digit = num % 10;
                if (digit % 2 != 0)
                {
                    hasOdd = true;
                    return hasOdd;
                }
                    num /= 10;
                }
            return hasOdd;
        }

    }

}
