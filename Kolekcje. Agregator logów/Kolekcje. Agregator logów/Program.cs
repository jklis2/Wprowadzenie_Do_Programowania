using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje._Agregator_logów
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string[]> aggregator = new SortedDictionary<string, string[]>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine().Split(" ");
                if (!aggregator.ContainsKey(temp[1]))
                {
                    aggregator.Add(temp[1], new[] { temp[0], temp[2] });
                    continue;
                }
                List<string> ip = new List<string>(aggregator[temp[1]][0].Split(", "));
                if (!ip.Contains(temp[0]))
                    ip.Add(temp[0]);
                ip.Sort();
                int duration = int.Parse(aggregator[temp[1]][1]);
                duration += int.Parse(temp[2]);
                string[] placeholder = new string[2] { String.Join(", ", ip.ToArray()), duration.ToString() };
                aggregator[temp[1]] = placeholder;
            }
            foreach (var key in aggregator)
            {
                Console.WriteLine($"{key.Key}: {key.Value[1]} [{key.Value[0]}]");
            }
        }
    }
}
