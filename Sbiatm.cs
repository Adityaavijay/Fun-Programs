using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    class SbiAtm : ATM
    {
        double accno;
        double accbal;
        string pass;
        string bknm;
        public SbiAtm(Accountget n1)
        {
            accno = n1._accNo;
            accbal = n1._accBalance;
            pass = n1._password;
            bknm = n1._bankName;
        }

        public void changePassword(double accNumber, string oldPassword, string newPassword)
        {
            Accountget obj = new Accountget(accno, accbal, pass, bknm);
            if (accno == accNumber)
            {
                if (pass == oldPassword)
                {
                    pass = newPassword;
                    obj.displayAccount();
                }
            }
            else
            {
                Console.WriteLine("Enter the correct accno");
            }
        }

        public void checkBalance()
        {
            Console.WriteLine("the existing balance is {0}",accbal);
        }

        public void withdraw(double accNumber, double amount)
        {
            Accountget obj = new Accountget(accno, accbal, pass, bknm);
            if (accno == accNumber)
            {
                obj.withdraw(amount);
                obj.displayAccount();
            }
        }
    }
}

