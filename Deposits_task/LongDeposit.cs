namespace Aggregation
{
    //Define public class "LongDeposit" that inherits from "Deposit".
    public class LongDeposit : Deposit
    {
        ////Define a constructor that calls the constructor of a base class.
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {

        }
		
        //Override method "Income" of base class according to the task.
        public override decimal Income()
        {
            if (Period > 6)
            {
                return Amount * (decimal)(Math.Pow((1.15), (Period - 6))) - Amount;
            }
            return 0;
        }
    }
}