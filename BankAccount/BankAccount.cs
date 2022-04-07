﻿namespace BankAccount
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



        public BankAccount(float _balance)
        {
            Balance = _balance;
        }

        public void Credit(int balanceIn)
        {
            Balance += balanceIn;
        }
        public void Debit(int balanceOut)
        {
            
            if (!Frozen)
            {
                float bsave = Balance - balanceOut;
                if (bsave >= 0)
                {
                    Balance -= balanceOut;
                }
                else
                {
                   throw new ArgumentOutOfRangeException("Insufficent Funds");
                }
                    
            }
            else
            {
                throw new ArgumentOutOfRangeException("Frozen");
            }
        }

    }
}