using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static bool valid = true;
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            CheckLength(password);
            ChechSymbols(password);
            CheckDigits(password);
            if (valid)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static void CheckLength(string password)
        {
            if (password.Length<6 || password.Length>10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                valid = false;
            }
        }
        static void ChechSymbols(string password)
        {
            foreach (char c in password)
            {
                bool isValid = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789".IndexOf(c) >= 0;
                if (!isValid)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    valid = false;
                    break;
                }
            }
        }
        static void CheckDigits(string password)
        {
            int counter = 0;
            foreach (char c in password)
            {
                bool isFound = "0123456789".IndexOf(c) >= 0;
                if (isFound)
                {
                    counter++;
                }
            }
            if (counter<2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                valid = false;
            }
        }
    }
}
