п»ї// See https://aka.ms/new-console-template for more information
using BankAccount;

Account account = new Account(AccountType.BankAccountType.DepositAccount);

StringLibrary reverseString = new StringLibrary();
reverseString.ReverseString = "abcde";
reverseString.PrintString(reverseString.ReverseString);
string? str = reverseString.returnReverseString();
reverseString.PrintString(str!);

reverseString.getStringFromFile();
string line = reverseString.getStringFromFile();
Console.WriteLine($"РЎС‚СЂРѕРєР° РґРѕ РІС‹Р·РѕРІР° РјРµС‚РѕРґР°: { line}");
reverseString.setStringInFile(line);
reverseString.SearchMail(ref line);
Console.WriteLine($"РЎС‚СЂРѕРєР° РїРѕСЃР»Рµ РІС‹Р·РѕРІР° РјРµС‚РѕРґР°: {line}");
Console.ReadKey();



