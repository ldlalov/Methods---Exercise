using System;
using System.Linq;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            SmallestOfThree(a, b, c);
        }
        static void SmallestOfThree(int a, int b, int c)
        {
            int[] numbers =  {a,b,c};
            Console.WriteLine(numbers.Min());
        }
    }
}
