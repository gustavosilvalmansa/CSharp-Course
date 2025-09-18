namespace Account.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public decimal Balance { get; protected set; }

        public Account() { }
        public Account(int number, string holder, decimal balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

    }
}
