namespace BankAccount
{
    public class BankAccount
    {
        
        private bool Frozen = false;
        public bool frozen
        {
            get
            {
                return Frozen;
            }
            set
            {
                Frozen = value;
            }

        }
        private float Balance = 0;
        public float balance
        {  
            get 
            { 
               return Balance; 
            }               
            set 
            {
               Balance = value; 
            }    
        
        }


        public void Credit(int balanceIn)
        {
            Balance += balanceIn;
        }
        public void Debit(int balanceOut)
        {
            if (!Frozen)
            {
                Balance -= balanceOut;
            }
        }

    }
}