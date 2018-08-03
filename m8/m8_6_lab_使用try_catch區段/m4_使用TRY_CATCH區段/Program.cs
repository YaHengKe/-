using System;

class Program
{
    static void MyColorWriteLine(string msg, ConsoleColor theColor, ConsoleColor original)
    {
        Console.WriteLine();
        Console.ForegroundColor = theColor;
        Console.WriteLine(msg);
        Console.ForegroundColor = original;
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.WriteLine("開始");
        string msg = "未知";
        bool 輸入違反規則;
        string 輸入的字串 = null;
        int i;
        do
        {
            MyColorWriteLine("請輸入介於 "
              + int.MinValue + " 到 " + int.MaxValue + " 的一個整數"
              , ConsoleColor.Cyan, original);
            輸入違反規則 = false;
            // fix #2 試試看 輸入介於 從 -2147483648 到 2147483647 的整數 , 會如何 ?
            // fix #3 試試看 輸入超出 此 -2147483648 到 2147483647 範圍的整數 , 會如何 ?
            輸入的字串 = Console.ReadLine();
            try
            {
                // fix #1 觀察下一行, 輸入的字串 一定可以成功的剖析成一個 int嗎?
                //        若不行則會丟出例外, 那會如何?
                i = int.Parse(輸入的字串);
                // fix #5 若上一行丟出例外,  觀察下面不會被執行到
                msg = (i % 2 == 0) ? "是偶數" : "是奇數";
                MyColorWriteLine(msg, ConsoleColor.Green, original);
            }
            catch (OverflowException caught)
            {
                MyColorWriteLine(caught.ToString(), ConsoleColor.Red, original);
                // fix 練習 #4    觀察下一行
                輸入違反規則 = true;
            }
        }
        while (輸入違反規則);
        Console.WriteLine();
        Console.WriteLine("結束");
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

