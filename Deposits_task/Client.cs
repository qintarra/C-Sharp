namespace Aggregation
{
    //Define public class "Client".
    public class Client
    {
        //Define private field "deposits" with the type of array of "Deposit".
        private readonly Deposit[] deposits;
		
        //Define a parameterless constructor that creates an empty array of deposits with the size of 10.
        public Client()
        {
            deposits = new Deposit[10];
        }
		
        //Define the public method "AddDeposit" that takes a deposit and adds it to "deposits". 
        //If the array of deposits has an empty place, returns true, else returns false.
        public bool AddDeposit(Deposit deposit)
        {
            for (int i = 0; i < 10; i++)
            {
                if(deposits[i] == null)
                {
                    deposits[i] = deposit;
                    return true;
                }
            }
            return false;
        }
		
        //Define the public method "TotalIncome" that returns the total income of all deposits upon their expiratio
        public decimal TotalIncome()
        {
            decimal sum = 0;

            for (int i = 0; i < 10; i++)
            {
                if(deposits[i] != null)
                {
                    sum += deposits[i].Income();
                }
            }
            return sum;
        }
		
        //Define the public method "MaxIncome" that returns the max value of income of all deposits of the client.
        public decimal MaxIncome()
        {
            decimal max = 0;

            for (int i = 0; i < 10; i++)
            {
                if (deposits[i] != null && max < deposits[i].Income())
                    max = deposits[i].Income();
            }
            return max;
			
			/* decimal max = deposits[0].Income();
            foreach (Deposit x in deposits)
            {
                if(x != null && max < x.Income())
                max = x.Income();
            }
            return max; */
        }
		
        //Define the public method "GetIncomeByNumber" that takes a number of deposits (index of deposit in array plus 1) 
        //that returns the income of this deposit.
        public decimal GetIncomeByNumber(int i)
        {
            if (deposits[i - 1] != null)
            {
                return deposits[i - 1].Income();
            }
            else
            {
                return 0;
            }
        }
    }
}