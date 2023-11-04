using static BankAccount.AccountType;

namespace BankAccount
{
    internal class Account : Identity, IOperationAccount
    {
        private decimal _balance;
        public long AccountNumber { get;}
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException(String.Format("Установленный баланс:{0}. Баланс не может быть отрицательным", value));
                }
                _balance = value;
            }
        }
        public BankAccountType AccountType { get; set; }      

        public Account() : base ()
        {
            Random randAccountNumber = new Random();
            AccountNumber = randAccountNumber.NextInt64(00000000000000000000, long.MaxValue);
            Balance = 0;
        }
        public Account(decimal balance, BankAccountType bankAccountTypes) : this()
        {
            Balance = balance;
            AccountType = bankAccountTypes;
        }
        public Account(BankAccountType bankAccountTypes) : this()
        {
            AccountType = bankAccountTypes;
        }
        public void Withdraw(Account account, decimal amount)
        {
            if (account.Balance >= amount)
            {
                Console.WriteLine($"{account.AccountNumber} с данного счета была снята сумма {amount}. Остаток на счету: {account.Balance}");
            }
            else
            {
                throw new Exception($"{account.AccountNumber} на данном счету не достаточно средств");
            }

        }
        public void Deposit(Account account, decimal amount)
        {
            account.Balance += amount;
            Console.WriteLine($"{account.AccountNumber} по данному счету произошло пополнение средств на сумму {amount}");
        }
    }
}