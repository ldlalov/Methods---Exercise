using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            NxN(num);

        }
        static void NxN(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int f = 0; f < num; f++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
