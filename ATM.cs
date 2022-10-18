using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    interface ATM
    {
        public void withdraw(double accNumber, double amount);
        public void changePassword(double accNumber, string oldPassword, string newPassword);

        public void checkBalance();
    }
}
