using System;
using System.Collections.Generic;
using System.Text;

namespace Scoreboard
{
    class Calc
    {
        public void Statsheet(int[] arr)
        {
            Dictionary<int, int> stats = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}   ", arr[i]);
            }
            Console.WriteLine();
            for (int j = 0; j < arr.Length; j++)
            {
                if (!stats.ContainsKey(arr[j]))
                {
                    stats.Add(arr[j], 0);
                }
                else
                {
                    stats[arr[j]]++;
                }
            }
            foreach (KeyValuePair<int, int> kv in stats)
            {
                Console.WriteLine("key - {0}| value - {1}", kv.Key, kv.Value);
            }
        }

        public void totruns(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}   ", arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("The total runs scored is {0}", sum);
        }
        public void average(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0}   ", arr[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double strikerate;
            strikerate = sum / arr.Length;
            Console.WriteLine(strikerate);
        }
    
    }
}
