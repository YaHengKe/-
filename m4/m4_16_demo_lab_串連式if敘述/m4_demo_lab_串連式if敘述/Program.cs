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
        trumps = 撲克牌花樣.梅花;
        Console.Write("trumps 的 撲克牌花樣 是        ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(trumps.ToString());
        Console.ForegroundColor = original;
        if (trumps == 撲克牌花樣.黑桃)
        {
            顏色 = "黑色";
            fg = ConsoleColor.DarkGray;
        }
        else//fix #1 觀察下一行, 將變數 "顏色" 設成 "紅色"  是對的嗎? 
            //  不是  撲克牌花樣.黑桃 , 並不代表一定是"紅色" 
            //  fix #3 將下一行註解取消, 就好多了
            //    if (trumps == 撲克牌花樣.紅心)
        {
            顏色 = "紅色";
            fg = ConsoleColor.Red;
        }
        //  fix #5 觀察下面, 將變數 顏色 設成 "黑色"  是對的嗎? 
        //     不是  撲克牌花樣.黑桃 也不是  撲克牌花樣.紅心
        //     , 並不代表一定是"黑色" 
        //  fix #4 將下六行註解取消
        //else
        //  //  if (trumps == 撲克牌花樣.梅花) //fix #6 將此註解取消, 就好多了
        //      {
        //          顏色 = "黑色";
        //          fg = ConsoleColor.DarkGray;
        //      }
        //  fix #7 將下五行註解取消 
        //   將變數 顏色 設成 "紅色"  是對的嗎? 
        //   不是  撲克牌花樣.黑桃 也不是  撲克牌花樣.紅心
        //   也不是  撲克牌花樣.梅花  , 那就是 撲克牌花樣.鑽石
        //    else
        //    {
        //      顏色 = "紅色";
        //      fg = ConsoleColor.Red;
        //    }

        Console.ForegroundColor = original;
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(" 它是 ");
        Console.WriteLine("##########################");
        Console.ForegroundColor = fg;
        //  fix #2 下一行印出的結果對嗎?
        Console.WriteLine(顏色);
        Console.ForegroundColor = original;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine(" 的牌");

        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
        
    }
}

