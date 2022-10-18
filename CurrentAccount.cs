using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    class CurrentAccount :Account
    {
        double overdraftlimit;

        public CurrentAccount()
        { }

        public CurrentAccount(double no, double balance, string pass, string banknm, double od) : base(no, balance, pass, banknm)
        {
            _overdraftlimit = od;
        }

        public double _overdraftlimit
        {
            get { return overdraftlimit; }
            set { overdraftlimit = value; }
        }

        public override void displayAccount()
        {
            Console.WriteLine(_accNo);
            Console.WriteLine(_accBalance);
            Console.WriteLine(_password);
            Console.WriteLine(_bankName);
            Console.WriteLine(_overdraftlimit);
        }

        public override void withdraw(double amount)
        {
            try 
            {
                if (_accBalance > amount && _accBalance > _overdraftlimit)
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
