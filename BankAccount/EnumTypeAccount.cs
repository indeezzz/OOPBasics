namespace BankAccount
{
	internal class AccountType
	{
		public enum BankAccountType
		{
			CheckingAccount,
			CurrentAccount,
			CreditAccount,
			DepositAccount,
			BudgetAccount
		}

		public string getTypeAccount (BankAccountType bankAcconutType)
		{
			switch (bankAcconutType)
			{
				case BankAccountType.CheckingAccount: 
					return $"��������� ����"; 
				case BankAccountType.CurrentAccount: 
					return $"������� ����";
				case BankAccountType.CreditAccount:
					return $"��������� ����";
				case BankAccountType.DepositAccount:
					return $"���������� ����";
				case BankAccountType.BudgetAccount:
					return $"��������� ����";
				default: return $"����������� ����";
			}
		}
	}
}
