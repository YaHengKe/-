using System;
class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        {
            TheDate W = null;
            Console.WriteLine();
            // fix #0 觀察下一行是在做什麼?
            W = new TheDate();
            Console.WriteLine("W = new TheDate();");
            Console.WriteLine("##################################");
            Console.Write("W.ccyy   為  ");
            Console.ForegroundColor = ConsoleColor.Red;
            // fix #1 觀察下一行會印出什麼?
            Console.WriteLine(W.ccyy);
            Console.ForegroundColor = original;
            Console.Write("W.mm     為  ");
            Console.ForegroundColor = ConsoleColor.Red;
            // fix #2 觀察下一行會印出什麼?
            Console.WriteLine(W.mm);
            Console.ForegroundColor = original;
            Console.Write("W.dd     為  ");
            Console.ForegroundColor = ConsoleColor.Red;
            // fix #3 觀察下一行會印出什麼?
            Console.WriteLine(W.dd);
            Console.ForegroundColor = original;
        }
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        {
            TheDate W;
            // fix #4 觀察下一行是在做什麼?
            W = new TheDate(2015, 8, 2);
            Console.WriteLine("W = new TheDate(2015, 8, 2);");
            Console.WriteLine("??????????????????????????????????");
            Console.Write("W.ccyy   為  ");
            Console.ForegroundColor = ConsoleColor.Green;
            // fix #5 觀察下一行會印出什麼?
            Console.WriteLine(W.ccyy);
            Console.ForegroundColor = original;
            Console.Write("W.mm     為  ");
            Console.ForegroundColor = ConsoleColor.Green;
            // fix #6 觀察下一行會印出什麼?
            Console.WriteLine(W.mm);
            Console.ForegroundColor = original;
            Console.Write("W.dd     為  ");
            Console.ForegroundColor = ConsoleColor.Green;
            // fix #7 觀察下一行會印出什麼?
            Console.WriteLine(W.dd);
            Console.ForegroundColor = original;
        }
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
    }
}
public class TheDate
{

    // fix #8 將下六行註解,  觀察會如何?
    public TheDate()
    {
        this.ccyy = 1970;
        this.mm = 1;
        this.dd = 1;
    }

    public TheDate(int y, int m, int d)
    {
        this.ccyy = y;
        this.mm = m;
        this.dd = d;
    }
    public int ccyy, mm, dd;
} // end of 類別, TheDate

