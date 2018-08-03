using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        int x = 3;
        int y = 5;
        Console.Write("x 為 ");
        Console.Write(x);
        Console.Write(" , y 為 ");
        Console.WriteLine(y);
        Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        Console.Write("(x > y) ? x : y 結果 為 ");
        // fix #1 觀察下行會印出什麼?
        Console.WriteLine((x > y) ? x : y);
        /* x > y 是假, 印出結果  5     */
        Console.WriteLine("####################################");
        Console.Write("x 為 ");
        Console.Write(x);
        Console.Write(" , y 為 ");
        Console.WriteLine(y);
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.Write("(x <= y) ? x : y 結果 為 ");
        // fix #2 觀察下行會印出什麼?
        Console.WriteLine((x <= y) ? x : y);
        /* x <= y  是真,      印         出結果 3      */
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

