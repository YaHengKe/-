using System;

enum 撲克牌花樣 { 梅花, 紅心, 鑽石, 黑桃 }

class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        ConsoleColor fg = original;
        string 顏色 = "未知顏色";
        撲克牌花樣 trumps;
        Console.WriteLine();
        // fix #2 將下一行的   紅心  改成   黑桃
        //      觀察下面 if 會不會執行的不合理 ?
        trumps = 撲克牌花樣.紅心;
        Console.Write("trumps 的 撲克牌花樣 是        ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(trumps.ToString());
        Console.ForegroundColor = original;
        if (trumps == 撲克牌花樣.黑桃)
        {
            顏色 = "黑色";
            fg = ConsoleColor.DarkGray;
        }
        //  fix #4 將下一行註解取消, 就好多了
        // else 
        // fix #1 觀察下面 敘述區段會不會被執行到? 
        {
            顏色 = "非黑色";
            fg = ConsoleColor.Green;
        }


        Console.ForegroundColor = original;
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(" 它是 ");
        Console.WriteLine("##########################");
        Console.ForegroundColor = fg;
        //  fix #3 下一行印出的結果對嗎?
        Console.WriteLine(顏色);
        Console.ForegroundColor = original;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine(" 的牌");

        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

