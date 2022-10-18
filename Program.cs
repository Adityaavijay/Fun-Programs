using System;

namespace Bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            double accountno;
            double accountbalance;
            string pwd;
            string nameofbank;
            double minb;
            double od;
            double amount;

            Console.WriteLine("Enter the acc.number");
            accountno = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.balance");
            accountbalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.password");
            pwd = Console.ReadLine();

            Console.WriteLine("Enter the bank name");
            nameofbank = Console.ReadLine();

            Account a1 = new Account(accountno, accountbalance, pwd, nameofbank);

            Console.WriteLine("Enter the acc.number");
            accountno = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.balance");
            accountbalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.password");
            pwd = Console.ReadLine();

            Console.WriteLine("Enter the bank name");
            nameofbank = Console.ReadLine();

            Account a2 = new Account(accountno, accountbalance, pwd, nameofbank);

            a1.displayAccount();
            a2.displayAccount();

            Console.WriteLine("Enter the acc.number");
            accountno = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.balance");
            accountbalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.password");
            pwd = Console.ReadLine();

            Console.WriteLine("Enter the bank name");
            nameofbank = Console.ReadLine();

            Console.WriteLine("Enter the minimum balance");
            minb = int.Parse(Console.ReadLine());

            SavingsAccount a3 = new SavingsAccount(accountno, accountbalance, pwd, nameofbank, minb);


            Console.WriteLine("Enter the acc.number");
            accountno = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.balance");
            accountbalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.password");
            pwd = Console.ReadLine();

            Console.WriteLine("Enter the bank name");
            nameofbank = Console.ReadLine();

            Console.WriteLine("Enter the over draft limit");
            od = int.Parse(Console.ReadLine());

            CurrentAccount a4 = new CurrentAccount(accountno, accountbalance, pwd, nameofbank, od);

            a3.displayAccount();
            Console.WriteLine("Enter the amount to be withdrawn");
            //check if balance > amount withdrawn
            amount = double.Parse(Console.ReadLine());
            a3.withdraw(amount);

            a4.displayAccount();
            a4.withdraw(amount);


            Console.WriteLine("Enter the acc.number");
            accountno = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.balance");
            accountbalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the acc.password");
            pwd = Console.ReadLine();

            Console.WriteLine("Enter the bank name");
            nameofbank = Console.ReadLine().ToLower();

            Accountget a5 = new Accountget(accountno, accountbalance, pwd, nameofbank);

            SbiAtm objsbi = new SbiAtm(a5);
            IciciAtm objicici = new IciciAtm(a5);

            if (nameofbank == "sbi")
            {
               objsbi.changePassword(121, "hi", "bye");
               objsbi.checkBalance();
               objsbi.withdraw(121, 25000);
            }
            else if (nameofbank == "icici")
            {
               objicici.changePassword(121, "hi", "bye");
               objicici.checkBalance();
               objicici.withdraw(121, 125000);
            }
            else
            {
               Console.WriteLine("Entered invalid bankname");
            }



            SavingsAccount s1 = new SavingsAccount(100, 100000, "Hello", "Sbi", 5000);
            SavingsAccount s2 = new SavingsAccount(101, 250000, "Hello1", "Icici", 10000);
            SavingsAccount s3 = new SavingsAccount(102, 200000, "Hello2", "Hdfc", 10000);
            SavingsAccount s4 = new SavingsAccount(103, 300000, "Bye", "Axis", 17000);
            InMemoryAccountDaoImpl ob1 = new InMemoryAccountDaoImpl();
            ob1.addAnAccount(s1);
            ob1.addAnAccount(s2);
            ob1.addAnAccount(s3);
            ob1.addAnAccount(s4);
            ob1.checkBalance();
            ob1.withdraw(101, 10000);

            AccountDaoImpl o1 = new AccountDaoImpl();
            o1.putinfo(1, 2, "hhhh", "gggg", 3);


        }
    }
}



