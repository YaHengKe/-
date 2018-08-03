using System;

public class Coordinate
{
    public double x;
    public double y;
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("開始");
        ConsoleColor original = Console.ForegroundColor;
        Coordinate c1 = new Coordinate();
        c1.x = 2.3;
        c1.y = 7.6;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.ForegroundColor = ConsoleColor.Green;
        // fix #1 觀察下一行會印出什麼?
        Console.WriteLine(c1.x + " , " + c1.y);
        Console.ForegroundColor = original;
        Console.WriteLine("##########################");
        Coordinate c2;
        c2 = c1;
        //  修改變數所參考的物件會影響對方所參考的物件
        //(因為參考的是同一個物件)
        // fix #3 將下兩行註解取消, 看會如何?
        // c2.x = 9.8;
        // c2.y = 4.5;
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #2 觀察下一行會印出什麼?
        Console.WriteLine(c1.x + " , " + c1.y);
        Console.ForegroundColor = original;
        Console.WriteLine("??????????????????????????");
        Console.WriteLine("結束");
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}
