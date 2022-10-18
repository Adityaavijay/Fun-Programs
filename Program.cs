using System.Collections;
using System.Collections.Generic;
using System;

namespace Scoreboard_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of innings played");
            int innings = int.Parse(Console.ReadLine());
            List<int[]> inn = new List<int[]>();
            for (int x = 0; x < innings; x++)
            {
                Console.WriteLine("Enter the no of overs played");
                int numofovers = int.Parse(Console.ReadLine());
                int n = numofovers * 6;
                int[] runs = new int[n];
                Random rn = new Random();
                for (int i = 0; i < n; i++)
                {
                    runs[i] = rn.Next(0, 7);
                }
                inn.Add(runs);
            }
            ConsoleKeyInfo status;

            while (true)
            {
                Calc dobj = new Calc();

                Console.WriteLine("Enter the stat to be checked \n 1.Total Runs\n 2.Strike Rate\n 3. Stats\n 4.Average score of last 5 matches");
                char ch = char.Parse(Console.ReadLine());
                Calc obj = new Calc();

                switch (ch)
                {
                    case '1':
                        {
                            obj.totruns(inn);
                            break;
                        }
                    case '2':
                        {
                            obj.average(inn);

                            break;
                        }
                    case '3':
                        {
                            obj.Statsheet(inn);

                            break;

                        }
                    case '4':
                        {
                            obj.score(inn);

                            break;

                        }
                    default:
                        {
                            Console.WriteLine("Enter the correct option");
                            break;
                        }
                }
                Console.WriteLine("Do you wish to continue(Y/y)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.N)
                {
                    break;
                }
            }
        }
    }
}
