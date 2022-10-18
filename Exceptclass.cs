using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_account
{
    class InvalidAmountException : Exception
    {
        public InvalidAmountException()
        {
            
        }
        public InvalidAmountException(double amount) : base(string.Format("amount is less {0} ",amount))
        { }

    }
    class InsufficientFundException:Exception
    {
        public InsufficientFundException()
        {
            
        }
        public InsufficientFundException(double balance) : base(string.Format("amount is less {0}",balance))
        { }
    }
}
