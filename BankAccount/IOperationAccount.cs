п»їusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    interface IOperationAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void TransferTo(Account account, decimal amount);
    }
}
