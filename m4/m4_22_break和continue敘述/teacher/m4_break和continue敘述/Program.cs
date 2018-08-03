using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("開始");
        Console.WriteLine();
        int i = 0;
        // fix # 0    觀察下面的while 
        while (true)
        {
            i++;

            if (i == 2)
            {
// fix # 3    請將下一行註解取消,  再執行此程式, 看會印出什麼?
                continue;
            }
            else if (i > 4)
            {
// fix # 2    請將下一行註解取消 ,  再執行此程式, 看會印出什麼?
                break;
            }
            Console.WriteLine(i);
            System.Console.Write("Hello, ");
            System.Console.WriteLine("C# programmers");
        }

        Console.WriteLine();
        Console.WriteLine();
        // fix # 1    執行此程式, 看會印出什麼?
        Console.WriteLine("結束");
        Console.WriteLine("i 為 " + i);
        Console.WriteLine("#####################################");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

