using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.WriteLine();
        int a = 6;
        Console.Write("a原本為 ");
        Console.WriteLine(a);       /* 為變數a的值 */
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("a++ (a後置遞增)為 ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // fix #1 請回答下行會印出什麼?
        Console.WriteLine(a++);   /* 為此後置運算式的值 */
        Console.ForegroundColor = original;
        Console.WriteLine("???????????????????????????????????????????????");
        Console.Write("a後來為 ");
        // 後置 a++    即   a = a  +   1
        // fix #2 請回答下行會印出什麼?
        Console.WriteLine(a);       /* 為變數a的值 */
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        Console.WriteLine();
        Console.WriteLine();
        a = 6;
        Console.Write("a原本為 ");
        Console.WriteLine(a);       /* 為變數a的值 */
        Console.WriteLine("###############################################");
        Console.WriteLine("++a (a前置遞增)為 ");
        Console.ForegroundColor = ConsoleColor.Red;
        // 前置 ++ a   即    a = a  +   1
        // fix #3 請回答下行會印出什麼?
        Console.WriteLine(++a);  /* 為此前置運算式的值 */
        Console.ForegroundColor = original;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.Write("a後來為 ");
        

        // fix #4 請回答下行會印出什麼?
        Console.WriteLine(a);      /* 為變數a的值 */
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

