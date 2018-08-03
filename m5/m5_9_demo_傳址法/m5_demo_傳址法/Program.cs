using System;
class Program
{
    static void OutDemo(ref int p)
    {
        p = p + 1;
    }
    static void Main(string[] args)
    {
        int n = 5;
        Console.WriteLine();
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine(n);
        Console.WriteLine("###############################");
        // fix #1 執行此程式, 看會如何?
        // fix #2 在下一行   n  之前加個 ref 保留字
        Program.OutDemo(     n  );
        // fix #3 觀察下一行程式, 會印出什麼?
        Console.WriteLine(n); //顯示 6 而不是 5
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

