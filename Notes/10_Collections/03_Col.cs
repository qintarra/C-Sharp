using System;
using System.Collections.Generic;
namespace Collections_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Bill Gates");
            names.Add("Steven Jobs");
            names.Add("Sergey Brin");
            names.Add("Mark Zuckerberg");
            //names.Add('A'); - Error !!!
            Console.WriteLine("Founders of the world's leading IT-companies:");
            foreach (string str in names)
            {
                Console.WriteLine(str);
            }
            //You can access it via the index
            Console.WriteLine("The founder of Microsoft is {0}", names[0]);
        }
    }
}