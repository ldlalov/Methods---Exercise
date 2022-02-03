using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static int[] array1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        static void Main(string[] args)
        {
            int[] array2 = array1;
            string command = Console.ReadLine();
            string[] cmd = command.Split().ToArray();
            if (cmd[0] == "exchange")//ако е Substring(0,8)"exchange", когато дойде вход max odd гърми заради недостатъчно символи
            {
                int index = int.Parse(cmd[1]);
                Exchange(index);
            }
            else if (command == "max even")
            {
                MaxEven();
            }
            else if (command == "max odd")
            {
                MaxOdd();
            }
            else if (command == "min even")
            {
                MinEven();
            }
            else if (command == "min odd")
            {
                MinOdd();
            }
            else if (cmd[0]== "first")
            {
                if (cmd[2] == "even")
                {
                    FirstEven(int.Parse(cmd[1]));
                }
            }
            //Console.WriteLine(string.Join(' ', array1));
            //string word = Console.ReadLine();  

        }
        static void Exchange(int index)
        {
            if (index <= array1.Length - 1)
            {
                int[] array12 = new int[array1.Length - index];
                int[] array11 = new int[array1.Length - array12.Length];
                for (int i = 0; i < index; i++)
                {
                    array11[i] = array1[i];
                }
                for (int i = index; i < array1.Length; i++)
                {
                    array12[i - index] = array1[i];
                }
                array1 = array12.Concat(array11).ToArray();
                Console.WriteLine(string.Join(' ', array1));
            }
        }
        static void MaxEven()
        {
            int index = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0 && i > index)
                {
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
        static void MaxOdd()
        {
            int index = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 != 0 && i > index)
                {
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
        static void MinEven()
        {
            int index = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0 && i < index)
                {
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
        static void MinOdd()
        {
            int index = array1[0];
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 != 0 && i < index)
                {
                    index = i;
                }
            }
            Console.WriteLine(index);
        }
        static void FirstEven(int count)
        {
            int index = array1[0];
            int [] tempArray = new int[count];
            for (int i = 0;i < count;i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array1[i] % 2 == 0 && index<)
                    {

                    }
                }
                    tempArray[i] = array1[i];
                
            }
            Console.WriteLine(string.Join(",",tempArray));
        }
    }
}
