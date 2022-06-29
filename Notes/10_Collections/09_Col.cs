using System;
using System.Collections;
namespace Collections_9
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList slColors = new SortedList();
            slColors.Add('w', "white");
            slColors.Add('b', "black");
            slColors.Add('g', "green");
            slColors.Add('r', "red");
            foreach (DictionaryEntry de in slColors)
            {
                Console.WriteLine($"Char '{de.Key}' is associated with {de.Value}");
            }
        }
    }
}