using System;
class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.WriteLine();
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@");
        // fix #1 觀察 for 敘述
        for (int i = 0, k = 0; i < 4; i += 1, k += 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("i 為 " + i);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("k 為 " + k);
        }
        Console.ForegroundColor = original;
        Console.WriteLine("########################");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}
