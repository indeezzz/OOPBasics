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
        private bool validAmount (decimal amount)
        {
            return amount <= Balance ? true : false;
        }
        public void Withdraw(decimal amount)
        {
            if (validAmount(amount))
            {
                Console.WriteLine($"{AccountNumber} с данного счета была снята сумма {amount}. Остаток на счету: {Balance}");
            }
            else
            {
                Console.WriteLine($"{AccountNumber} на данном счету не достаточно средств");
            }

        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{AccountNumber} по данному счету произошло пополнение средств на сумму {amount}");
        }

        public void TransferTo(Account account, decimal amount)
        {
            if(validAmount(amount))
            {
                Balance -= amount;
                account.Balance += amount;
                Console.WriteLine($"Перевод средств на номер счета {account.AccountNumber} успешен.");
            }
            else
            {
                Console.WriteLine($"{AccountNumber} на данном счету не достаточно средств для перевода");
            }
        }
    }
}