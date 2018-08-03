using System;
class Program
{
    // fix #5 觀察下一行的 SF
    static int SF; // 靜態變數
    static void PR()
    {
        ConsoleColor original = Console.ForegroundColor;
// fix #4 將下一行的 LV = 0 改成 LV  看會如何?
//        若有語法錯誤, 再將下一行的  LV  改回成 LV = 0
        int LV = 0; /* 區域變數 */
        LV += 1;
        Program.SF += 1;
        Console.Write("此方法 Program.PR( ) 第 ");
        Console.ForegroundColor = ConsoleColor.Green;
        // fix #6 將下一行的 LV 改成 Program.SF  
        //         再執行, 看會如何?
        Console.Write(SF);
        Console.ForegroundColor = original;
        Console.WriteLine(" 次被呼叫");
    }
    static void Main(string[] args)
    {
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        // fix #1 執行, 看下一行會如何?
        Program.PR();
        Console.WriteLine("########################################");
        // fix #2 執行, 看下一行會如何?
        Program.PR();
        Console.WriteLine("????????????????????????????????????????");
        // fix #3 執行, 看下一行會如何?
        Program.PR();
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
        Program.SF = 5;
        Console.WriteLine(Program.SF);
    }
}

