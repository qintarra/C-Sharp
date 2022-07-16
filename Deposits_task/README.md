## Aggregation

Create classes **Deposit** (bank account), **BaseDeposit** (regular deposit), **SpecialDeposit** (special deposit), **LongDeposit** (long-term deposit), **Client** (bank client) with set functionality.  

1. Create an abstract class **Deposit** and declare within it:
- Public money property only for reading **Amount** (deposit amount)
- Public integer property only for reading **Period** (time of deposit in months)
- Constructor (for calling in class-inheritor) with parameters **depositAmount** and **depositPeriod**, which creates object deposit with a specified sum for a specified period.
- Abstract method **Income**, which returns money value – the amount of income from the deposit. Income is the difference between sum, withdrawn from deposit upon expiration date, and deposited sum.

2. Сreate classes that are inheritors of the class **Deposit**, which determine different options of deposit interest addition – class **BaseDeposit**, class **SpecialDeposit**, and class **LongDeposit**. To implement in each class a constructor with parameters **amount** and **period**, which calls constructor of parent class.

3. For each inheritor class – to implement its own interest addition scheme and accordingly profit margin definitions, overriding abstract method **Income** in each class.

**BaseDeposit** implies each month 5% of the interest from the current deposit sum. Each following month of income is calculated from the sum, which was received by adding to the current income sum of the previous month and is rounded to the hundredth.  
Example:  
Base amount – 1000,00  
In a month – 1050,00; income amount – 50,00  
In two months – 1102,50; income amount – 102,50  
In three months – 1157,62; income amount – 157,62  

**SpecialDeposit** implies income addition each month, the amount of which (in percent) equals to deposit expiration period. If during the first month 1% is added, during the second month – 2% from the sum obtained after the first month and so on.  
Example:   
Base amount – 1000,00  
In a month – 1010,00; income amount – 10,00  
In two months – 1030,20; income amount – 30,20  

**LongDeposit** implies that during the first 6 months, no percent is added to the client’s deposit, but starting from the 7th month, each month's percent addition is 15% from the current deposit sum, thus encouraging a client to make long-term deposits.

4. Create class **Client** (bank client) and declare within it:
- Private field **deposits** (client deposits) – objects array of type Deposit
- Constructor without parameters, which creates empty array deposits consisting of 10 elements
- Method **AddDeposit** with parameter **deposit** for adding regular, special, or long-term account into the array on the first empty spot and returning true, or returning false, if the accounts number limit is depleted (no empty space in the array).
- Method **TotalIncome**, returning total income amount based on all client’s deposits upon deposit expiration.
- Method **MaxIncome**, returning maximum deposit income of all client’s deposits upon deposits expiration.
- Method **GetIncomeByNumber** with integer parameter **number** (deposit number, which equals its index in the array, increased by one), returning income from the deposit with such number. If a deposit with such number does not exist, the method returns a 0 value.