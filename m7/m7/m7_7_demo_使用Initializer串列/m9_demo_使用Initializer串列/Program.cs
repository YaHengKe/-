using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        TheDate W;
        // fix #2 觀察下一行會如何?
        W = new TheDate();
        Console.WriteLine("###################################");
        // fix #3 觀察下三行會印出什麼?
        Console.WriteLine("W.ccyy 為 " + W.ccyy);
        Console.WriteLine("W.mm   為 " + W.mm);
        Console.WriteLine("W.dd   為 " + W.dd);
        TheDate t;
        // fix #4 觀察下一行會如何?
        t = new TheDate(1999, 9, 28);
        Console.WriteLine("???????????????????????????????????");
        // fix #5 觀察下三行會印出什麼?
        Console.WriteLine("t.ccyy   為 " + t.ccyy);
        Console.WriteLine("t.mm     為 " + t.mm);
        Console.WriteLine("t.dd     為 " + t.dd);
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
    }
}
public class TheDate
{
    public TheDate(int y, int m, int d)
    {
        this.ccyy = y;
        this.mm = m;
        this.dd = d;
    }
    public TheDate()
    {
    }
    // fix #1 觀察下三行會何時執行?
    // 先執行 Initializer串列 , 再輪到constructor建構子 被執行
    public int ccyy  /*Initializer串列*/   = 2038;
    public int mm    /*Initializer串列*/   = 12;
    public int dd    /*Initializer串列*/   = 31;
}

