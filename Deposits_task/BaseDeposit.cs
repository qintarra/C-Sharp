namespace Aggregation
{
    //Define public class "BaseDeposit" that inherits from "Deposit".
    public class BaseDeposit : Deposit
    {
		
        //Define constructor that calls constructor of a base class.
        public BaseDeposit(decimal amount, int period) : base (amount, period)
        {
            
        }
		
        //Override method "Income" of base class according to the task.
        public override decimal Income()
        {
            return Amount * (decimal)Math.Pow(1.05, Period) - Amount;
        }
    }
}