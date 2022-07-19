using System;
using System.Text;

namespace Algorithms
{
    class Program
    {
        static string ReverseEachWord(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            string[] arr = input.Split(" ");
            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(Reverse(arr[i]));
                if (i != arr.Length - 1)
                {
                    result.Append(' ');
                }
            }
            return result.ToString();
        }

        static string Reverse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Tom Cruise is a great actor"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("neveroddoreven"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));
        }
    }
}