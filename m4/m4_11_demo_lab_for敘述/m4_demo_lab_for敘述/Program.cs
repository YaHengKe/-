using System;
class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.WriteLine();
        int i;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("先試 while");
        // fix #1 執行此程式, 觀察 while 敘述執行情形
        i = 0;
        // fix #3 將下一行註解取消, 再觀察 while 敘述執行情形
        // i = 7;
        while (i < 4)
        {
            Console.Write(i + " ");
            // fix #2 將下一行註解, 再觀察 while 敘述執行情形, 觀察完再將下一行註解取消, 再執行此程式
            i++;
        }
        int x = 1;
        while (x<50)
        {
            Console.WriteLine(x+" ");
            x += 1;
        }


        Console.WriteLine();
        Console.WriteLine("#############################");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("再試試 for");
        i = 7;
        // fix #5 執行此程式, 觀察 for 敘述執行情形
        for (i = 0; i < 4; i++)
        {
            Console.Write(i + " ");
            // fix #4 觀察 下一行  
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

        for (int j = 1; j <= 9; j++)
        {
            for (int k = 1; k <= 9; k++)
            {
                Console.Write(" {0} x {1} = ", j, k);
                if (j * k < 10)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(j*k);
            }
        }




    }
}

