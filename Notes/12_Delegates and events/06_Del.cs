using System;
namespace Delegate_6
{
    //Catching exceptions when calling a delegate
    delegate void Del(ref string s);
    class Program
    {
        public static void GoodMethod1(ref string s)
        {
            Console.WriteLine("Method GoodMethod1 called");
            if (s.Contains("Java"))
            {
                s = s.Replace("Java", "C#");
            }
        }
        public static void GoodMethod2(ref string s)
        {
            Console.WriteLine("Method GoodMethod2 called");
            s = s.ToUpper() + " !!!";
        }
        public static void BadMethod(ref string s)
        {
            Console.WriteLine("Method BadMethod called ");
            throw new Exception(); // simulate an exception
        }
        static void Main(string[] args)
        {
            string s = "I like Java";
            Del d = new Del(GoodMethod1);   //instantiating a delegate
            d += new Del(BadMethod);        //addition of the list of methods
            d += new Del(GoodMethod2);      //addition of the list of methods
            //d(ref s);

            foreach (Del fun in d.GetInvocationList())
            {
                try
                {
                    fun(ref s); //calling each method from the list
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Exception in method " + fun.Method.Name);
                }
            }
            Console.WriteLine("Result – {0}", s);
        }
    }
}