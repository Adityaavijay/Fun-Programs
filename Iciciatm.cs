using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    class IciciAtm : ATM
    {
        double accno;
        double accbal;
        string pass;
        string bknm;

        public IciciAtm(Accountget n2)
        {
            accno = n2._accNo;
            accbal = n2._accBalance;
            pass = n2._password;
            bknm = n2._bankName;
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
            Console.WriteLine("the existing balance is {0}", accbal);
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
