using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Factoial_Division(num1, num2):f2}"); 
        }
        static double Factoial_Division(int num1,int num2)
        {
            double result1 = 1;
            double result2 = 1;
            for (int i = num1; i > 0; i--)
            {
                if (num1==0)
                {
                    result1 = 1;
                    break;
                }
                result1*=i;
            }
            for (int i = num2; i > 0; i--)
            {
                if (num2==0)
                {
                    result2 = 1;
                    break;
                }
                result2*=i;
            }

            return result1/result2;
        }
    }
}
