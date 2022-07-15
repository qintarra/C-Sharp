## Aggregation

Create classes **Deposit** (bank account), **BaseDeposit** (regular deposit), **SpecialDeposit** (special deposit), **LongDeposit** (long-term deposit), **Client** (bank client) with set functionality.  

1. Create an abstract class **Deposit** and declare within it:
- Public money property only for reading **Amount** (deposit amount)
- Public integer property only for reading **Period** (time of deposit in months)
- Constructor (for calling in class-inheritor) with parameters **depositAmount** and **depositPeriod**, which creates object deposit with a specified sum for a specified period.
- Abstract method **Income**, which returns money value – the amount of income from the deposit. Income is the difference between sum, withdrawn from deposit upon expiration date, and deposited sum.