using System;
class Program {
    static void Main(string[] args) {
        ConsoleColor original = Console.ForegroundColor;
        int x = 3;
        int y = 5;
        Console.Write("x為 ");
        Console.WriteLine(x);       /* 為變數x的值 */
        Console.Write("y為 ");
        Console.WriteLine(y);       /* 為變數x的值 */
        Console.WriteLine();
        bool a = true;
        Console.Write("a原本為 ");
        Console.WriteLine(a);       /* 為變數a的值 */
        Console.WriteLine(" a = x > y;");
        a = x > y;
        Console.Write("a後來為 ");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #1 請回答下行會印出什麼?
        Console.WriteLine(a);   /* 為此x>y運算式的值 */
        Console.ForegroundColor = original;
        Console.WriteLine("???????????????????????????????????????????????");
        Console.WriteLine(" a = x < y ;");
        a = x < y;
        Console.Write("a後來為 ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // fix #2 請回答下行會印出什麼?
        Console.WriteLine(a);       /* 為變數a的值 */
        Console.ForegroundColor = original;
        Console.WriteLine("###############################################");
        Console.WriteLine(" a = x >= y  ;");
        a = x >= y;
        Console.Write("a後來為 ");
        Console.ForegroundColor = ConsoleColor.Green;
        // fix #3 請回答下行會印出什麼?
        Console.WriteLine(a);       /* 為變數a的值 */
        Console.ForegroundColor = original;
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
        Console.WriteLine(" a = x == y  ;");
        a = x == y;
        Console.Write("a後來為 ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        // fix #4 請回答下行會印出什麼?
        Console.WriteLine(a);   /* 為此x>y運算式的值 */
        Console.ForegroundColor = original;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine(" a = x != y    ;");
        a = x != y;//!=會先做
        Console.Write("a後來為 ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        // fix #5 請回答下行會印出什麼?
        Console.WriteLine(a);       /* 為變數a的值 */
        Console.ForegroundColor = original;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine(" a = x <= y    ;");
        a = x <= y;
        Console.Write("a後來為 ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        // fix #6 請回答下行會印出什麼?
        Console.WriteLine(a);       /* 為變數a的值 */
        Console.ForegroundColor = original;
        Console.WriteLine();
        Console.WriteLine();
    }
}

