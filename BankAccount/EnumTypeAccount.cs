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
					return $"Расчетный счет"; 
				case BankAccountType.CurrentAccount: 
					return $"Текуший счет";
				case BankAccountType.CreditAccount:
					return $"Кредитный счет";
				case BankAccountType.DepositAccount:
					return $"Депозитный счет";
				case BankAccountType.BudgetAccount:
					return $"Бюджетный счет";
				default: return $"Неизвестный счет";
			}
		}
	}
}
