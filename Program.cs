using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Console.Write("Input integers:");
            task_1(Console.ReadLine());

            Console.WriteLine("Task 2:");
            Console.Write("Base's length:");
            task_2(Convert.ToInt16(Console.ReadLine()));

            Console.WriteLine("Task 3:");
            Console.Write("Input characters:");
            task_3(Console.ReadLine());

            Console.ReadLine();
        }
        public static void task_1(string input)
        {
            int[] array = new int[input.Length];
            int i = 0;
            int count = 1;
            int t = 0;
            int temp = 0;
            int[] num = new int[array.Length];
            foreach (char c in input)
            {
                string number = Convert.ToString(c);
                array[i] = Convert.ToInt32(number);
                if (i > 0 && array[i] == array[i - 1])
                {
                    count++;
                    num[i] = count;
                }
                else
                {
                    count = 1;
                    num[i] = count;
                }
                if (num[i] > temp)
                {
                    temp = num[i];
                    t = i;
                }

                i++;
            }
            Console.WriteLine(Convert.ToString("Integer from the longest recurring sequence is " + array[t]));
        }
        public static void task_2(int length)
        {
            if (length % 2 != 0)
            {
                int spaces = (length - (length / 2));
                for (int i = 1; i <= length; i = i + 2)
                {
                    spaces--;
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                int spaces = (length - (length / 2));
                for (int i = 1; i <= length; i = i + 2)
                {
                    spaces--;
                    for (int j = 1; j <= spaces; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i + 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static void task_3(string input)
        {
            Dictionary<char, char> bracketPairs = new Dictionary<char, char>() {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' },
            };
            bool notBalanced = false;
            Stack<char> brackets = new Stack<char>();

            foreach (char c in input)
            {
                if (bracketPairs.Keys.Contains(c))
                {
                    brackets.Push(c);
                }
                else
                {
                    if (bracketPairs.Values.Contains(c))
                    {
                        if (c == bracketPairs[brackets.First()])
                        {
                            brackets.Pop();
                        }
                        else
                        {
                            Console.WriteLine(input + " is not balanced");
                            notBalanced = true;
                            break;
                        }
                    }
                }
            }
            if (brackets.Count() == 0)
            {
                Console.WriteLine(input + " is  balanced");
            }
            if (brackets.Count > 0 && notBalanced == false)
            {
                Console.WriteLine(input + " is not balanced");
            }
        }
    }
}
