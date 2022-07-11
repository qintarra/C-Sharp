using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace BF_2
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
            ArrayList mylist = new ArrayList();
            mylist.Add(new Demo(2, 4.5, new DateTime(2018, 11, 18)));
            mylist.Add(new Demo(5, 2.6, new DateTime(2019, 12, 25)));
            mylist.Add(new DateTime(2020, 05, 15));

            FileStream fs = new FileStream(@"C:\Demo\file2.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fs, mylist);
            Console.WriteLine("Serialization - OK");

            fs.Close();
            fs = new FileStream(@"C:\Demo\file2.dat", FileMode.Open);

            ArrayList newlist = null;

            newlist = (ArrayList)formatter.Deserialize(fs);
            Console.WriteLine("Deserialization - OK");

            foreach (object x in newlist)
            {
                Console.WriteLine(x);
            }
        }
    }
}