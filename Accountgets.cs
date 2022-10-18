using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    class Accountget : Account
    {
        // has accno,accbalance,pwd and bankname stored
        public Accountget(double no, double balance, string pass, string banknm):base(no,balance,pass,banknm)
        { }
        public override void withdraw(double amount)
        {
            if (_accBalance > amount)
            {
                _accBalance = _accBalance - amount;
                Console.WriteLine("the new balance is {0}",_accBalance);
            }
            else
            {
                Console.WriteLine("Balance insufficient");
            }
        }
    }
}
