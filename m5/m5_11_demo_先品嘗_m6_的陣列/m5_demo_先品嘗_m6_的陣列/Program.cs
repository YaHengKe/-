using System;
class Program
{
    static void Main(string[] args)
    {
        long[] v;
        // fix #1 觀察下面程式的執行
        v = new long[4] { 9, 2, 3, 4 };

        long total, i;
        for (i = 0, total = 0; i < v.Length; i++)
            total += v[i];

        Console.WriteLine("??????????????????????????");
        Console.WriteLine(total);
        Console.WriteLine("##########################");
        Console.WriteLine();
        Console.WriteLine();
        
    }
    

}
