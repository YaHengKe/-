using System;

class Program
{
    static void PassCoor(Coordinate c2)
    {
        //  修改變數所參考的物件會影響對方所參考的物件
        //(因為參考的是同一個物件)
        c2.x += 1;
        c2.y += 1;
    }
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.WriteLine("開始");
        Coordinate loc = new Coordinate();
        loc.x = 2;
        loc.y = 4;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // fix #1 觀察下一行會印出什麼?
        Console.WriteLine(loc.x + " , " + loc.y);
        Console.ForegroundColor = original;
        // fix #3 將下一行註解取消, 看會如何?
        // Program.PassCoor(loc);
        Console.WriteLine("##########################");
        Console.ForegroundColor = ConsoleColor.Green;
        // fix #2 觀察下一行會印出什麼?
        Console.WriteLine(loc.x + " , " + loc.y);
        Console.ForegroundColor = original;
        Console.WriteLine("??????????????????????????");
        Console.WriteLine("結束");
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}
public class Coordinate
{
    public double x;
    public double y;
}
