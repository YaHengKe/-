using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.WriteLine();
        Console.WriteLine("######################");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #1 觀察 可否執行此程式?
        for (int i = 0; i < 4; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.ForegroundColor = original;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine();
        Console.WriteLine();
        // fix #2  將下一行註解 再觀察 可否執行此程式?
        Console.WriteLine("i為" + i);
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

