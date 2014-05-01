using System;
using System.Collections.Generic;
using System.Linq;

class RunLotto
{
    static void Main(string[] args)
    {
        List<int> l = new List<int>();
        for (int i = 1; i <= 45; i++)
            l.Add(i);
        for (int j = 0; j < 50; j++)
        {
            Lotto.Shuffle(ref l);
            for (int i = 0; i < 6; i++)
                Console.Write("{0} ", l[i]);
            Console.WriteLine();
        }
    }
}

class Lotto
{
    public static void Shuffle(ref List<int> l)
    {
        int temp1;
        int temp2;
        int idx;
        Random r = new Random();
        for (int i = 0; i < l.Count; i++)
        {
            idx = r.Next(0, (l.Count - 1));
            temp1 = l[i];
            temp2 = l[idx];
            l.RemoveAt(i);
            l.Insert(i, temp2);
            l.RemoveAt(idx);
            l.Insert(idx, temp1);
        }
    }
}