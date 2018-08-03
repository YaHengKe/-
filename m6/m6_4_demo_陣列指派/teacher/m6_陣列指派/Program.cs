using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleColor origin = Console.ForegroundColor;
        Console.WriteLine();
        long[] row = new long[4] { 3, 71, 2, 5 };
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        long[] copy = row;
        Console.WriteLine("long[] copy = row;");
        Console.WriteLine("####################################################");
        Console.Write("row[0] 為 ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(row[0]);
        Console.ForegroundColor = origin;
        Console.WriteLine("????????????????????????????????????????????????????");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // fix #2 將下兩行註解取消, 會如何?
        Console.WriteLine("copy[0] = copy[0] + 1;");
        copy[0] = copy[0] + 1;
        Console.ForegroundColor = origin;
        Console.Write("row[0] 為 ");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #1 觀察下一行會印出什麼?
        Console.WriteLine(row[0]);
        Console.ForegroundColor = origin;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
    }
}

