using System;
 
namespace OOP_5
{   
	class Worker
    {
        private string firstname;
        private string lastname;
        private int salary;
        public static int total_salary;

        //Constructor
        public Worker(string firstname, string lastname, int salary)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.salary = salary;
            total_salary += salary;
        }
    class Program
        {
            static void Main(string[] args)
            {
                Worker w1 = new Worker("Mark", "Zukerberg", 3000000);
                Worker w2 = new Worker("Bill", "Gates", 2500000);
                Console.WriteLine($"Total salary {Worker.total_salary}");
            }
        }
    }
}