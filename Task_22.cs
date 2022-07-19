using System;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // IsPalindrome returns a tuple of two values
            static (bool, int) IsPalindrome(string theString)
            {
                string teststr;

                // Convert the string to lower-case
                teststr = theString.ToLower();

                // Use a StringBuilder to strip out all the punctuation
                var sb = new StringBuilder();
                foreach (char c in teststr)
                {
                    // Add characters to the builder if not punctuation or white space
                    if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c))
                    {
                        sb.Append(c);
                    }
                }
                // Convert the builder to the finished string
                teststr = sb.ToString();

                // compare characters starting at beginning and end of string
                int i = 0, j = teststr.Length - 1;
                // if the indexes cross each other, then we're done
                while (i <= j)
                {
                    // if the character at each index doesn't match, it's not a palindrome
                    if (teststr[i] != teststr[j])
                    {
                        return (false, 0);
                    }
                    // update the counters and try again
                    i++;
                    j--;
                }
                // if we reach this point, we must have a palindrome
                return (true, theString.Length);
            }

            string inputstr = "";
            (bool b, int l) result;
            Console.WriteLine("Welcome to the \"Palindrome\" program! Type a word or phrase and the program will check if it's palindrome.");
            Console.WriteLine("Type \"exit\" to stop the program.");
            Console.WriteLine("Let's begin:");
            while (inputstr != "exit")
            {
                inputstr = Console.ReadLine();
                if (inputstr != "exit")
                {
                    result = IsPalindrome(inputstr);
                    Console.WriteLine($"Palindrome: {result.b}, Length: {result.l}");
                }
            }
        }
    }
}
