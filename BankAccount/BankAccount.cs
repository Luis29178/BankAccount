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
            if (_balance <= 100000 && _balance >= 0)
            {
                Balance = _balance;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Fail");
            }
        }

        public bool Credit(int balanceIn)
        {
            if (balanceIn <= 0 || balanceIn >= 10000)
            {
                throw new ArgumentOutOfRangeException("Fail");
            }

            if (!Frozen)
            {
                float bsave = Balance + balanceIn;
                if (bsave <= 100000)
                {
                    Balance += balanceIn;
                    return true;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Fail");
                }

            }
            else
            {
                throw new ArgumentOutOfRangeException("Fail");
            }

        }
        public bool Debit(int balanceOut)
        {
            if (balanceOut <= 0 || balanceOut >= 10000)
            {
                throw new ArgumentOutOfRangeException("Fail");
            }
            if (!Frozen)
            {
                float bsave = Balance - balanceOut;
                if (bsave >= 0)
                {
                    Balance -= balanceOut;
                    return true;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Fail");
                }
                
            }
            else
            {
                throw new ArgumentOutOfRangeException("Fail");
            }
        }

    }
}