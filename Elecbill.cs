using System;
using System.Collections.Generic;
using System.Text;

namespace Electricity_bill
{
    class Elecbill
    {
        public void Calculate(double u)
        {
            double price = 0,u1,u2;

            if (u <= 100)
            {
                price = u * 1.20;
            }
            else if (u > 100 && u <= 300)
            {
                u1 = u - 100;
                price = (u1 * 2) + (100 * 1.2);
            }
            else
            {
                u2 = u - 300;
                price = (u2 * 3) + (100 * 1.2) + (200 * 2);
            }
            Console.WriteLine("The toatal bill is {0}", price);
        }
    }
}
