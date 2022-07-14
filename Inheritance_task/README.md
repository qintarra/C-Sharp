# Inheritance

Create classes Employee, SalesPerson, Manager, and Company with predefined functionality.

1. Create basic class **Employee** and declare the following content:
- Three closed fields – text field **name** (employee last name), money fields – **salary** and **bonus**
- Public property **Name** for reading employee’s last name
- Public property **Salary** for reading and recording salary field
- Constructor with a parameters string **name** and **money** salary (last name and salary are set)
- Virtual method **SetBonus** that sets bonuses to salary, the amount of which is delegated/conveyed as a bonus
- Method **ToPay** that returns the value of summarized salary and bonus.

2. Create class **SalesPerson** as class **Employee** inheritor and declare within it:

- Closed integer field **percent** (percent of sales targets plan performance/execution)
- Constructor with parameters: **name** – employee last name, **salary**, **percent** – percent of plan performance,  
first two of which are passed to basic class constructor
- Redefine the virtual method of parent class **SetBonus** in the following way:  
if the sales person completed the plan more than 100%, his bonus is doubled (is multiplied by 2),  
and if more than 200% – the bonus is tripled (is multiplied by 3)  

3. Create class **Manager** as **Employee** class inheritor, and declare with it:

- Closed integer field **quantity** (number of clients, who the manager served during a month)
- Constructor with parameters string **name** – employee last name, **salary** 
and integer **clientAmount** – number of served clients, first two of which are passed to basic class constructor.
- Redefine the virtual method of parent class **SetBonus** in the following way: 
if the manager served over 100 clients, his bonus is increased by 500, and if more than 150 clients – by 1000.

4. Create class **Company** and declare within it:

- Closed field **employees** (staff) – an array of Employee type.
- Constructor that receives employee array of **Employee** type with arbitrary length
- Method **GiveEverybodyBonus** with money parameter **companyBonus** that sets the amount of basic bonus for each employee.
- Method **TotalToPay** that returns total amount of salary of all employees including awarded bonus
- Method **NameMaxSalary** that returns employee last name, who received maximum salary including bonus.