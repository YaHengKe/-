using System;
class Program
{
    static void AddOne(int B)
    {
        B = B + 1; 	//遞增 B 參數的內容值
    }
    static void Main(string[] args)
    {
        Console.WriteLine();
        int B = 6;
        Console.WriteLine("###############################");
        Console.WriteLine(B);
        Console.WriteLine("???????????????????????????????");
        Program.AddOne(B);
        // fix #1 觀察下一行會印出什麼?
        Console.WriteLine(B); //顯示 6   而不是 7
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

