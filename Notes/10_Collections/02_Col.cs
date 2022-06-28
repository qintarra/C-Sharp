using System;
using System.Collections;
namespace Collections_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();
            a.Add("C # is here!");
            a.Add("Hell to World!");
            a.Add("I will survive!");
            a.Add(1);
            a.Add('r');
            a.Add(3.45);
            a.Add(true);
            a.Add(DateTime.Now);
            a.Add(new object());
            a.Add(new { Name = "Bill", LastName = "Gates" });
            foreach (object obj in a)
            {
                Console.WriteLine(obj);
            }
            // You can work as with a regular array
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}