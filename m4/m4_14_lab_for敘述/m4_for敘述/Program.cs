using System;
class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.WriteLine();

        int i;

        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("先試 while");
        // fix #1 執行此程式, 觀察下面 while 敘述執行情形
        i = 0;
        // fix #3 將下一行註解取消, 再觀察下面 while 敘述執行情形
        // i = 7;
        while (i < 4)
        {
            Console.Write(i + " ");
            // fix #2 將下一行註解, 再觀察此 while 敘述執行情形
            //         , 觀察完再將下一行註解取消, 再執行此程式
            i++;
        }
        Console.WriteLine();
        Console.ForegroundColor = original;
        Console.WriteLine("#############################");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("再試試 for");
        // fix #5 觀察 下一行,  再觀察此 for 敘述執行情形
        i = 7;
        for (i = 0; i < 4; i++)
        {
            Console.Write(i + " ");
            // fix #4 觀察 下一行,  再觀察此 for 敘述執行情形
            // i++  ;
        }

        Console.WriteLine();
        Console.ForegroundColor = original;
        Console.WriteLine("?????????????????????????????");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

