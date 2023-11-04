п»їusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    interface IOperationAccount
    {
        void Deposit(Account account, decimal amount);
        void Withdraw(Account account, decimal amount);
    }
}
