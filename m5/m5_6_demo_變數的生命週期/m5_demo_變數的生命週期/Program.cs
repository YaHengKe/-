using System;
class Program
{
    static public int AC;
    static void B()
    {
        Program.AC += 1;
        Console.WriteLine(Program.AC);
    }
    static void S()
    {
        int T = 0;
        T += 1;
        Console.WriteLine(T);
    }
    static void Main(string[] args)
    {
        ConsoleColor ori = Console.ForegroundColor;
        Console.WriteLine("開始");
        Console.WriteLine("###############################");
        Console.ForegroundColor = ConsoleColor.Green;
        // fix #1 觀察下面會如何?
        Program.S();
        Program.S();
        Program.S();
        Console.ForegroundColor = ori;
        Console.WriteLine("???????????????????????????????");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Program.B();
        Program.B();
        Program.B();
        Console.ForegroundColor = ori;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("結束");
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

