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
		
        //Define public method 'GiveEverbodyBonus' with money parameter 'companyBonus', that sets the amount of basic bonus for each employee.
        public void GiveEverybodyBonus(decimal companyBonus)
        {
            foreach (Employee employee in employees)
            {
                employee.SetBonus(companyBonus);
            }
        }
		
        //Define public method 'TotalToPay', that returns the total amount of salary of all employees including awarded bonus.
        public decimal TotalToPay(decimal salary)
        {
            decimal totalSalary = 0;
            foreach (Employee employee in employees)
            {
                totalSalary += employee.ToPay();
            }
            return totalSalary;
        }
		
    }
}
