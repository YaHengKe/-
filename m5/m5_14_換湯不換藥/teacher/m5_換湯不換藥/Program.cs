using System;
class Program
{
    static void 湯 ()
    {
        // 藥
        ConsoleColor original = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        for (int i = 1; i <= 20; i++)
        {
            Console.Write('#');
        }
        Console.WriteLine();
        Console.ForegroundColor = original;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("開始");
        // fix #1 觀察講師示範換湯不換藥

        Console.WriteLine("準備第一次");
        // 湯
        Program.湯();
        //{
        //    // 藥
        //    ConsoleColor original = Console.ForegroundColor;
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    for (int i = 1; i <= 20; i++)
        //    {
        //        Console.Write('#');
        //    }
        //    Console.WriteLine();
        //    Console.ForegroundColor = original;
        //}
        Console.WriteLine("準備第二次");
        // 湯
        Program.湯();
        //{
        //    ConsoleColor original = Console.ForegroundColor;
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    for (int i = 1; i <= 20; i++)
        //    {
        //        Console.Write('#');
        //    }
        //    Console.WriteLine();
        //    Console.ForegroundColor = original;
        //}
        Console.WriteLine("準備第三次");
        // 湯
        Program.湯();
        //{
        //    ConsoleColor original = Console.ForegroundColor;
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    for (int i = 1; i <= 20; i++)
        //    {
        //        Console.Write('#');
        //    }
        //    Console.WriteLine();
        //    Console.ForegroundColor = original;
        //}
        Console.WriteLine("結束");
        Console.WriteLine(); 
        Console.WriteLine();
    }
}

