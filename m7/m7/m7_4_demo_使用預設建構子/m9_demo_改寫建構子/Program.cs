using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        ConsoleColor original = Console.ForegroundColor;
        TheDate W;
        W = new TheDate();
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.Write("W.ccyy   為  ");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #1 觀察下一行會印出什麼?
        Console.WriteLine(W.ccyy);
        Console.ForegroundColor = original;
        Console.WriteLine("########################");
        Console.Write("W.mm     為  ");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #2 觀察下一行會印出什麼?
        Console.WriteLine(W.mm);
        Console.ForegroundColor = original;
        Console.WriteLine("????????????????????????");
        Console.Write("W.dd     為  ");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #3 觀察下一行會印出什麼?
        Console.WriteLine(W.dd);
        Console.ForegroundColor = original;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
    }
}
public class TheDate
{
    //public TheDate() {
    //    
    //}
    public int ccyy, mm, dd;
}

