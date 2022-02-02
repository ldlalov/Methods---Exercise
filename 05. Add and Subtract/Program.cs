using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int int1 = int.Parse(Console.ReadLine());
           int int2 = int.Parse(Console.ReadLine());
           int int3 = int.Parse(Console.ReadLine());
            Subtract(int1, int2, int3); 
        }
        static int Sum(int int1, int int2)
        {
            return int1 + int2; 
        }
        static void Subtract(int int1, int int2, int int3)
        {
            int result = Sum(int1, int2) - int3;
            Console.WriteLine(result);
        }
    }
}
