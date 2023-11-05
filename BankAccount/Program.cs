п»ї// See https://aka.ms/new-console-template for more information
using BankAccount;

Account account = new Account(AccountType.BankAccountType.DepositAccount);
StringLibrary reverseString = new StringLibrary();
reverseString.ReverseString = "abcde";
reverseString.PrintString(reverseString.ReverseString);
string? str = reverseString.returnReverseString();
reverseString.PrintString(str!);
reverseString.ReverseString.Reverse();
Console.ReadKey();



