using System;
namespace Delegate_2
{
    //delegate declaration
    delegate void Del();
    class SampleClass
    {
        public void InstanceMethod()
        {
            Console.WriteLine("Instance method called.");
        }
        static public void StaticMethod()
        {
            Console.WriteLine("Static method called.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();

            // Instance method
            Del d = sc.InstanceMethod;
            d();

            // Static method
            d = SampleClass.StaticMethod;
            d();
        }
    }
}
