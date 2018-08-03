using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleColor origin = Console.ForegroundColor;
        Console.WriteLine();
        Console.WriteLine("設定陣列元素的初值"); Console.WriteLine();
        {
            int[,] grid =
                    // new int [ 2 , 3 ]
                    // fix #1 觀察給初值的語法
                {
                    {5, 4, 3},
                    {2, 1, 0}
                };

            int 第0維大小 = grid.GetLength(0);
            int 第1維大小 = grid.GetLength(1);
            Console.WriteLine("??????????????????????????????????????????????????????????");
            for (int y = 0; y < 第0維大小; y++)
            {
                for (int x = 0; x < 第1維大小; x++)
                {
                    Console.Write("grid[" + y + "," + x + "]  為 ");
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Console.Write(grid[y, x]);

                    Console.ForegroundColor = origin;
                    Console.Write("    ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
        Console.WriteLine();
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
    }
}

