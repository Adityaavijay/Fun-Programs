using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Bank_account
{
    class InMemoryAccountDaoImpl : AccountDao
    {
        double accountno;
        double accountbalance;
        string pwd;
        string nameofbank;
        double minb;

        static List<SavingsAccount> arr = new List<SavingsAccount>();

        public double Accountno { get => accountno; set => accountno = value; }
        public double Accountbalance { get => accountbalance; set => accountbalance = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Nameofbank { get => nameofbank; set => nameofbank = value; }
        public double Minb { get => minb; set => minb = value; }

        public InMemoryAccountDaoImpl()
        {
           
        }
        public void addAnAccount(SavingsAccount account)
        {
            arr.Add(account);
            Accountno = account._accNo;
            Accountbalance = account._accBalance;
            Pwd = account._password;
            Nameofbank = account._bankName;
            Minb = account._minimumbalance;
           
        }

        public void changePassword(int accountNumber, string oldPassword, string newPassword)
        {
            foreach (var i in arr)
            {

                if (i._accNo.Equals (accountNumber))
                {
                    if (oldPassword.Equals(i._password))
                    {
                        i._password = newPassword;
                    }
                }
            }
           
        }

        public void checkBalance()
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i._accBalance);
            }
        }

        public void getAccountDetails(int accountNumber)
        {
            foreach (var i in arr)
            {
                if (i._accNo.Equals(accountNumber))
                {
                    Console.WriteLine(i._accBalance);
                    Console.WriteLine(i._password);
                    Console.WriteLine(i._bankName);
                }
            }
        }

        public List<SavingsAccount> viewAllAccounts()
        {
            return arr;
          
        }

        public void withdraw(int accountNumber, double amount)
        {
            foreach (var i in arr)
            {
                if (i._accNo.Equals(accountNumber))
                {
                    i._accBalance = i._accBalance - amount;
                    Console.WriteLine(i._accBalance);
                }
            }
        }
    }
}
