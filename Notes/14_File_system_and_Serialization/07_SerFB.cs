using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace BF_1
{
    [Serializable]
    class Demo
    {
        int n;
        double d;
        DateTime dt;
        public Demo (int n, double d, DateTime dt)
        {
            this.n = n;
            this.d = d;
            this.dt = dt;
        }
        public override string ToString()
        {
            string s = String.Format("Field 1 = {0}, Field 2 = {1}, Field 3 = {2}", n, d, dt.ToShortDateString());
            return s;
        }
        static void Main(string[] args)
        {
            //Create an object of the Demo class
            Demo d = new Demo(5, 2.7, DateTime.Now);
            Console.WriteLine("Original object");
            Console.WriteLine(d);
            //Create a file
            FileStream fs = new FileStream(@"C:\Demo\file.dat", FileMode.Create);
            //Create an object of the BinaryFormatter class
            BinaryFormatter formatter = new BinaryFormatter();
            //Serializing the object
            formatter.Serialize(fs, d);
            //Close the file
            fs.Close();

            //Opening the file for reading
            fs = new FileStream(@"C:\Demo\file.dat", FileMode.Open);
            //Declaring a new object of the Demo class
            Demo d1 = null;
            //Restoring the object (deserializing)
            d1 = (Demo)formatter.Deserialize(fs);
            Console.WriteLine("Refurbished object");
            Console.WriteLine(d1);
        }
    }
}