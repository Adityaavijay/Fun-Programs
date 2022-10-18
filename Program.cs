using System;

namespace Scoreboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of overs played");
            int numofovers = int.Parse(Console.ReadLine());
            int n = numofovers * 6;
            int[] runs = new int[n];
            Random rn = new Random();
            for (int i = 0; i < n; i++)
            {
                runs[i] = rn.Next(0, 6);
            }
            ConsoleKeyInfo Status;
            while (true)
            {
                
                Calc dobj = new Calc();

                Console.WriteLine("Enter the stat to be checked \n 1.Total Runs\n 2.Strike Rate\n 3. Stats");
                char ch = char.Parse(Console.ReadLine());
                Calc obj = new Calc();

                switch (ch)
                {
                    case '1':
                        {
                            obj.totruns(runs);
                            break;
                        }
                    case '2':
                        {
                            obj.average(runs);

                            break;
                        }
                    case '3':
                        {
                            obj.Statsheet(runs);

                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Enter the correct option");
                            break;
                        }
                }
                Console.WriteLine("do u want to continue(Y/y)");
                Status = Console.ReadKey();
                if (Status.Key == ConsoleKey.N)
                {
                    break;
                }
            }
            
            
        }
    }
}
