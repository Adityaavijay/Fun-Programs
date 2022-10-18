using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    class SavingsAccount:Account
    {
        double minimumbalance;

        public SavingsAccount()
        { 
        }

        public SavingsAccount(double no, double balance, string pass, string banknm,double minb) : base(no,balance,pass,banknm)
        {
            _minimumbalance = minb;
        }
        public double _minimumbalance
        {
            set { minimumbalance = value;}
            get { return minimumbalance; }
        }

        public override void displayAccount()
        {
            Console.WriteLine(_accNo);
            Console.WriteLine(_accBalance);
            Console.WriteLine(_password);
            Console.WriteLine(_bankName);
            Console.WriteLine(_minimumbalance);
        }

        public override void withdraw(double amount)
        {
            try
            {
                if (_accBalance > amount && _accBalance > _minimumbalance)
                {
                    _accBalance = _accBalance - amount;
                    Console.WriteLine(_accBalance);
                }
                else
                {
                    throw new InsufficientFundException();
                }
            }
            catch (InsufficientFundException e)
            {
                throw new Exception(e.Message);
            }
        }
    }

}
