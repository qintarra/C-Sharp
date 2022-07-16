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
In a month – 105,00; income amount – 50,00
In two months – 1102,50; income amount – 102,50
In three months – 1157,62; income amount – 157,62