п»ї// See https://aka.ms/new-console-template for more information
using BankAccount;

Account account1 = new Account(500, AccountType.BankAccountType.DepositAccount); 
Account account = new Account(AccountType.BankAccountType.DepositAccount);
Console.WriteLine(account1.Balance);
account1.TransferTo(account, 300);
Console.WriteLine(account.Balance);
Console.WriteLine(account1.Balance);
account1.TransferTo(account, 300); 
Console.ReadKey();
