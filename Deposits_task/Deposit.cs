namespace Aggregation
{
    //Define public abstract class "Deposit"
    public abstract class Deposit
    {
        //Define public readonly property "Amount" with decimal type.
        public decimal Amount { get; }
		
        //Define public readonly property "Period" with int type.
        public int Period { get; }
		
        //Define constructor that gets "Amount" and "Period" and assigns them to its properties.
        public Deposit(decimal amount, int period)
        {
            Amount = amount;
            Period = period;
        }
		
        //Define public abstract method "Income" that returns deposit profit depending on "Amount" and "Period".
        public abstract decimal Income();
    }
}