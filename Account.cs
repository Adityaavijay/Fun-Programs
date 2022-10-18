using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    abstract class Account
    {
        double accNo;
        double accBalance;
        string password;
        public string bankName;

        public Account()
        {
        }

        public Account(double no, double balance, string pass, string banknm)
        {
            _accNo = no;
            _accBalance = balance;
            _password = pass;
            _bankName = banknm;
        }
        public double _accNo
        {
            set { accNo = value; }
            get { return accNo; }
        }
        public double _accBalance
        {
            set { accBalance = value; }
            get { return accBalance; }
        }
        public string _password
        {
            set { password = value; }
            get { return password; }
        }

        public string _bankName {
            get => bankName;
            set => bankName = value;
        }

        public virtual void displayAccount()
        {
            Console.WriteLine("Account no : {0}",_accNo);
            Console.WriteLine("Account balance : {0}", _accBalance);
            Console.WriteLine("Account password : {0}", _password);
            Console.WriteLine("bank name : {0}", _bankName);

        }

        public abstract void withdraw(double amount);
       

      
    }
}
