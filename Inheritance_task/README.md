# Inheritance

Create classes Employee, SalesPerson, Manager, and Company with predefined functionality.

1. Create basic class **Employee** and declare the following content:
- Three closed fields – text field **name** (employee last name), money fields – **salary** and **bonus**
- Public property **Name** for reading employee’s last name
- Public property **Salary** for reading and recording salary field
- Constructor with a parameters string **name** and **money** salary (last name and salary are set)
- Virtual method **SetBonus** that sets bonuses to salary, the amount of which is delegated/conveyed as a bonus
- Method **ToPay** that returns the value of summarized salary and bonus.