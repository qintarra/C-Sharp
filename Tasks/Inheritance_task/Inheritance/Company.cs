using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
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
        public decimal TotalToPay()
        {
            decimal totalSalary = 0;
            foreach (Employee employee in employees)
            {
                totalSalary += employee.ToPay();
            }
            return totalSalary;
        }
		
        //Define public method 'NameMaxSalary', that returns employee last name, who received maximum salary including bonus.
        public string NameMaxSalary()
        {
            int index = 0;

            for (int i = 1; i < employees.Length; i++)
            {
                if (employees[index].ToPay() < employees[i].ToPay())
                {
                    index = i;
                }
            }
            return employees[index].Name;
        }
    }
}
