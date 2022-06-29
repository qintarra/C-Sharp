using System;
using System.Collections;
namespace Collections_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable currencies = new Hashtable();
            currencies.Add("US", "Dollar");
            currencies.Add("Japan", "Yen");
            currencies.Add("France", "Euro");
            currencies.Add("Australia", "Dollar");
            Console.WriteLine("US Currency: {0}", currencies["US"]);
            foreach (DictionaryEntry x in currencies)
                Console.WriteLine($"{x.Key} {x.Value}");
        }
    }
}