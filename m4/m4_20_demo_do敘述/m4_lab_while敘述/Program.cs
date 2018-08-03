using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.Write("開始");
        Console.WriteLine(); Console.WriteLine();
        int i;
        Console.WriteLine("i = 7;");
        i = 7;
        Console.WriteLine();
        Console.WriteLine("試試 while");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        // fix #1 觀察下面的while執行起來, 會如何?
        while (i < 4)
        {
            Console.Write(i + " ");
            i++;
        }
        Console.WriteLine("###########################################");
        Console.WriteLine();
        Console.WriteLine("i = 7;");
        i = 7;
        Console.WriteLine();
        Console.WriteLine("試試 do");
        Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #2 觀察下面的do執行起來, 會如何?
        do
        {
            Console.Write(i + " ");
            i++;
        }
        while (i < 4);
        Console.WriteLine();
        Console.ForegroundColor = original;
        Console.WriteLine("???????????????????????????????????????????");
        Console.WriteLine();
        Console.WriteLine("i = 0;");
        i = 0;
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("再試試 do");
        Console.ForegroundColor = ConsoleColor.Green;
        // fix #3 觀察下面的do執行起來, 會如何?
        do
        {
            Console.Write(i + " ");
            i++;
        }
        while (i < 10);
        Console.WriteLine();
        Console.ForegroundColor = original;
        Console.Write("結束");
        Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

