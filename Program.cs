using System;

namespace Electricity_bill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no of units consumed");
            double units = double.Parse(Console.ReadLine());
            Elecbill e = new Elecbill();
            e.Calculate(units);

        }
    }
}
