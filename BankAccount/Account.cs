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
                    throw new ArgumentException(String.Format("������������� ������:{0}. ������ �� ����� ���� �������������", value));
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
                Console.WriteLine($"{account.AccountNumber} � ������� ����� ���� ����� ����� {amount}. ������� �� �����: {account.Balance}");
            }
            else
            {
                throw new Exception($"{account.AccountNumber} �� ������ ����� �� ���������� �������");
            }

        }
        public void Deposit(Account account, decimal amount)
        {
            account.Balance += amount;
            Console.WriteLine($"{account.AccountNumber} �� ������� ����� ��������� ���������� ������� �� ����� {amount}");
        }
    }
}