namespace Game
{
    class Wallet
    {
        private int defaultBalance = 250;
        private int balance;
        public int Balance { get; private set; }
        public Wallet(int amount)
        {
            balance = amount;
            defaultBalance = amount;

        }
        public Wallet()
        {
            ResetBalance();
        }
        public void ResetBalance()
        {
            balance = defaultBalance;
        }
        public int Amount()
        {
            return balance;
        }
        public void Increase(int Amount)
        {
            balance += Amount;
        }
        public void Decrease(int Amount)
        {
            balance -= Amount;
        }
        public bool Has(int Amount)
        {
            return balance >= Amount;
        }
        public bool Greater(int Amount)
        {
            return balance > Amount;
        }
        public bool Lesser(int Amount)
        {
            return balance < Amount;
        }
        public override string ToString()
        {
            return "$" + balance.ToString();
        }
        public bool isEmpty()
        {
            return balance <= 0;
        }
        public bool isNotEmpty()
        {
            return !isEmpty();
        }
    }






}