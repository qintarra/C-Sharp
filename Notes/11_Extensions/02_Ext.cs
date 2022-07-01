using System;
namespace ExtensionMethods_2
{
    public static class StringExtension
    {
        // Extension method for counting the number of words in a sentence
        public static int WordCount(this string str)
        {
            string[] words = str.Split(new char[] { ' ', ',', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // Extension method for counting the number of a specific letter in a sentence
        public static int LetterCount(this string str, char letter)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == letter)
                    count++;
            return count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Another heartache, another failed romance, on and on, does anybody know what we are living for?";

            int words = s.WordCount();
            Console.WriteLine("Word count of s is {0}", words);
            int count = s.LetterCount('o');
            Console.WriteLine("Count of letter o is {0}", count);
        }
    }
}