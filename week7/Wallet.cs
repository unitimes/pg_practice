using System;
using System.Collections.Generic;
using System.Linq;

class RunWallet
{
    static void Main(string[] args)
    {
        List<Student> s = new List<Student> ();
        string tName;
        int num;

        Console.WriteLine("학생 이름을 입력하세요. (qqq: 종료)");
        while(true)
        {
            tName = Console.ReadLine();
            if (tName == "qqq")
                break;
            s.Add(new Student(tName));
        }

        Console.Write("몇명 선택하시겠습니까? (1 - {0})", Student.total);
        num = Convert.ToInt32(Console.ReadLine());
        Wallet.Shuffle(ref s);

        for (int i = 0; i < num; i++)
        {
            if (i < (num - 1))
                Console.Write(s[i].name + ", ");
            else
                Console.WriteLine(s[i].name + " 님이 밥을 사세요.");
        }
    }
}

public class Student
{
    public static int total;
    public string name;
    public int id;

    public Student(string name)
    {
        total++;
        this.name = name;
        id = total;
    }
}

public class Wallet
{
    public static void Shuffle(ref List<Student> s)
    {
        Student temp1;
        Student temp2;
        int idx;
        Random r = new Random();
        for (int i = 0; i < s.Count; i++)
        {
            idx = r.Next(0, (s.Count - 1));
            temp1 = s[i];
            temp2 = s[idx];
            s.RemoveAt(i);
            s.Insert(i, temp2);
            s.RemoveAt(idx);
            s.Insert(idx, temp1);
        }
    }
}