using System;
class Program
{
    static void Main(string[] args)
    {
        // fix #6-2 將下一行註解取消, 會如何?
        //            double  i ;
        // fix #3  觀察下面  while 迴圈
        // fix #4  在此按 Ctrl + F5 鍵
        //          , 看會如何?
        i = 1.0;
        while ( i <= 4.0 )
        {
            Console.Write(" " + i);
            i = i + 1;
        }
        // fix #6-1 將下一行再變成註解
        // fix #5-1 將下一行註解取消, 觀察會如何?
        // double i ;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

