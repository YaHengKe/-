using System;
class Program
{
    // fix #2 修改下行
    //     將 long [ ] v 改成 params long [ ] v
    static long AddList(    long [ ] v  )
    {
        long total, i;
        for (i = 0, total = 0; i < v.Length; i++)
            total += v[i];
        return total;
    }
    static void Main(string[] args)
    {
        Console.WriteLine();
        // fix #1 執行此程式, 會發生什麼事?
        long x = Program.AddList( 6, 2, 3 );
        // fix #3 觀察會印出什麼?
        Console.WriteLine(x); //顯示11
        Console.WriteLine("###########################################");
        long y;
        y = Program.AddList( 5, 4 );
        // fix #4 觀察會印出什麼?
        Console.WriteLine(y); //顯示9
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

