using System;
class Program
{
    static void Main(string[] args)
    {
        ConsoleColor origin = Console.ForegroundColor;
        Console.WriteLine();
        Console.WriteLine("陣列的每一個元素都會有預設的初值");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // fix #2 執行此程式, 看下面 for會印出什麼?
            long[] row = new long[4];
            for (int i = 0; i < row.Length; i++)
            {
                Console.WriteLine(row[i]);
            }
            Console.ForegroundColor = origin;
        }
        Console.WriteLine("##################################");
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            // fix #3 執行此程式, 看下面 for會印出什麼?
            // 宣告陣列變數不等於建立陣列
            // fix #1 觀察下行的 null 是什麼?
            long[] row = null;
            // fix #5 將下行註解, 再執行此程式, 看會如何?
            row = new long[4];
            for (int i = 0; i < row.Length; i++)
            {
                Console.WriteLine(row[i]);
            }
        }
        Console.ForegroundColor = origin;
        // fix #4 執行此程式, 看下面會印出什麼?
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("??????????????????????????????????");
        Console.WriteLine("你可能看不到這個訊息被印出來");
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.ForegroundColor = origin;
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

