using System;
using System.Collections.Generic;
using System.Text;


namespace Task_21_4
{
    //Create public class 'Company' here.
    public class Company
    {
        //Define closed field employees (staff) – an array of 'Employee' type.
        private readonly Employee[] employees;
		
        //Define constructor that receives employee array of 'Employee' type with arbitrary length.
        public Company (Employee[] employees)
        {
            this.employees = employees;
        }
		
    }
}
