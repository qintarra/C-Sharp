using System;
using System.Collections;
using System.Collections.Generic;
namespace Collections_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashtable = new Hashtable();
            var dictionary = new Dictionary<string, int>();
            hashtable["key1"] = 5;
            Console.WriteLine("hashtable.key1 = {0}", hashtable["key1"]);
            Console.WriteLine("hashtable.key2 = {0}", hashtable["key2"]);
            dictionary["key1"] = 5;
            Console.WriteLine("dictionary.key1 = {0}", dictionary["key1"]);
            Console.WriteLine("dictionary.key2 = {0}", dictionary["key2"]); //Exception here
        }
    }
}