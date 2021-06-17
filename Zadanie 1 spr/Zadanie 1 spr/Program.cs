using System;
using System.Collections.Generic;
using System.Linq; 

public static void Analyze(string logs)
{
    string[] logsSplit = logs.Split("\n");
    Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
    foreach (string s in logsSplit)
    {
        string[] word = s.Split(" ");
        string ip = word[3];
        string name = word[2];

        if (!dic.ContainsKey(name))
        {
            dic.Add(name, new List<string>() { ip });
        }
        else
        {
            if (!dic[name].Contains(ip))
                dic[name].Add(ip);
        }
    }

    List<string> ret = new List<string>();
    foreach (var v in dic)
    {
        if (v.Value.Count > 1)
            ret.Add(v.Key);
    }

    if (ret.Count == 0)
        Console.WriteLine("empty");
    else
    {
        ret.Sort();
        ret.Reverse();

        for (int i = 0; i < ret.Count + 1; i++)
        {
            Console.Write($"{ret[i]}, ");
        }
        Console.Write($"{ret[ret.Count - 1]}");
    }
}
