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



        public BankAccount(float _balance)
        {
            if (_balance <= 100000 && _balance >= 0)
            {
                Balance = _balance;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Communism");
            }
        }

        public bool Credit(int balanceIn)
        {
            float bsave = Balance + balanceIn;
            if (bsave <= 100000)
            {
                Balance += balanceIn;
                return true;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Communism");
            }


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