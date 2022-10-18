using System;
using System.Collections.Generic;
using System.Text;

namespace Scoreboard_2
{
    class Calc
    {
        public void Statsheet(List<int[]> l)
        {
            Dictionary<int, int> stats = new Dictionary<int, int>();
            foreach (int[] x in l)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Console.Write("{0}  ", x[i]);
                }

                for (int j = 0; j < x.Length; j++)
                {
                    if (!stats.ContainsKey(x[j]))
                    {
                        stats.Add(x[j], 0);
                    }
                    else
                    {
                        stats[x[j]]++;
                    }
                }
            }
            foreach (KeyValuePair<int, int> kv in stats)
            {
                Console.WriteLine("key - {0}| value - {1}", kv.Key, kv.Value);
            }
        }

        public void totruns(List<int[]> l)
        {
            int sum = 0;
            foreach (int[] x in l)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Console.Write("{0}  ", x[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < x.Length; i++)
                {
                    sum += x[i];
                }
            }
            Console.WriteLine("The total runs scored is {0}", sum);
        }
        public void average(List<int[]> l)
        {
            double sum = 0;
            int totovers = 0;
            foreach (int[] x in l)
            {
                for (int i = 0; i < x.Length; i++)
                {
                    Console.Write("{0}  ", x[i]);
                }
                for (int i = 0; i < x.Length; i++)
                {
                    sum += x[i];
                    totovers += 1;
                }
            
            }
            double strikerate;
            strikerate = sum / totovers;
            Console.WriteLine(strikerate);
        }
        public void score(List<int[]> l)
        {
            double sum = 0;
            int totovers = 0;
            int c = l.Count;
            if (c < 5)
            {
                foreach (int[] z in l)
                {

                    for (int i = 0; i < z.Length; i++)
                    {
                        sum += z[i];
                        totovers += z.Length;
                    }

                }
            }
            else
            {
                for (int y = c-5; y < c; y++)
                {
                    for (int i = 0; i < l[y].Length; i++)
                    {
                        sum += l[y][i];
                        totovers += 1;
                    }

                }
            }
            double strikerate;
            strikerate = sum / totovers;
            Console.WriteLine(strikerate);
        }
    }
}
