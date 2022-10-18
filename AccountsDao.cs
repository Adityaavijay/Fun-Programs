using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    interface AccountDao
    {
        public void addAnAccount(SavingsAccount account);
        public void withdraw(int accountNumber, double amount);

        public void checkBalance();

        public void changePassword(int accountNumber,string oldPassword,string newPassword);

        List<SavingsAccount> viewAllAccounts();

        public void getAccountDetails(int accountNumber);

    }
}
