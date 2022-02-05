using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] cmd = command.Split().ToArray();
                if (cmd[0] == "exchange")
                {
                    int index = int.Parse(cmd[1]);
                    Exchange(array1, index);
                }
                else if (command == "max even")
                {
                    MaxEven(array1);
                }
                else if (command == "max odd")
                {
                    MaxOdd(array1);
                }
                else if (command == "min even")
                {
                    MinEven(array1);
                }
                else if (command == "min odd")
                {
                    MinOdd(array1);
                }
                else if (cmd[0] == "first")
                {
                    if (cmd[2] == "even")
                    {
                        FirstEven(array1, int.Parse(cmd[1]));
                    }
                    if (cmd[2] == "odd")
                    {
                        FirstOdd(array1, int.Parse(cmd[1]));
                    }
                }
                else if (cmd[0] == "last")
                {
                    if (cmd[2] == "even")
                    {
                        LastEven(array1, int.Parse(cmd[1]));
                    }
                    if (cmd[2] == "odd")
                    {
                        LastOdd(array1, int.Parse(cmd[1]));
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ",array1)}]");
        }
        static void Exchange(int[] array1, int index)
        {
            int numberOfRotations = index;

            if (numberOfRotations > array1.Length - 1 || numberOfRotations < 0)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int rotation = 0; rotation <= numberOfRotations; rotation++)
            {
                int firstNumber = array1[0];

                for (int i = 1; i < array1.Length; i++)
                {
                    array1[i - 1] = array1[i];
                }

                array1[array1.Length - 1] = firstNumber;
            }
        }
        static void MaxEven(int[] array1)
        {
            int index = array1[0];
            int value = int.MinValue;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0 && array1[i] >= value)
                {
                    value = array1[i];
                    index = i;
                }
            }
            if (index > int.MinValue)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void MaxOdd(int[] array1)
        {
            int index = 0;
            int value = int.MinValue;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 != 0 && array1[i] >= value)
                {
                    value = array1[i];
                    index = i;
                }
            }
            if (index > int.MinValue)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void MinEven(int[] array1)
        {
            int index = array1[0];
            int value = int.MaxValue;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0 && array1[i] <= value)
                {
                    value = array1[i];
                    index = i;
                }
            }
            if (value < int.MaxValue)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void MinOdd(int[] array1)
        {
            int index = array1[0];
            int value = int.MaxValue;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 != 0 && array1[i] <= value)
                {
                    value = array1[i];
                    index = i;
                }
            }
            if (value < int.MaxValue)
            {
                Console.WriteLine(index);
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
        static void FirstEven(int[] array1, int count)
        {
            if (count <= array1.Length)
            {
                int tempcount = 0;
                string[] tempArray = new string[count];
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] % 2 == 0 && tempcount < tempArray.Length)
                    {
                        tempArray[tempcount] = array1[i].ToString();
                        tempcount++;
                    }
                }
                tempArray = tempArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Console.WriteLine($"[{String.Join(", ", tempArray)}]");
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }
        static void FirstOdd(int[] array1, int count)
        {
            if (count <= array1.Length)
            {
                int tempcount = 0;
                string[] tempArray = new string[count];
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] % 2 != 0 && tempcount < tempArray.Length)
                    {
                        tempArray[tempcount] = array1[i].ToString();
                        tempcount++;
                    }
                }
                tempArray = tempArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Console.WriteLine($"[{String.Join(", ", tempArray)}]");
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }
        static void LastEven(int[] array1, int count)
        {
            if (count <= array1.Length)
            {
                int tempcount = count;
                string[] tempArray = new string[count];
                for (int i = array1.Length - 1; i >= 0; i--)
                {
                    if (array1[i] % 2 == 0 && tempcount - 1 >= 0)
                    {
                        tempArray[tempcount - 1] = array1[i].ToString();
                        tempcount--;
                    }
                }
                tempArray = tempArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Console.WriteLine($"[{String.Join(", ", tempArray)}]");
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }
        static void LastOdd(int[] array1, int count)
        {
            if (count <= array1.Length)
            {
                int tempcount = count;
                string[] tempArray = new string[count];
                for (int i = array1.Length - 1; i >= 0; i--)
                {
                    if (array1[i] % 2 != 0 && tempcount - 1 >= 0)
                    {
                        tempArray[tempcount - 1] = array1[i].ToString();
                        tempcount--;
                    }
                }
                tempArray = tempArray.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                Console.WriteLine($"[{String.Join(", ", tempArray)}]");
            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }
    }
}
