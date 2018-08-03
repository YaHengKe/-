using System;
enum 撲克牌花樣 { 梅花, 紅心, 鑽石, 黑桃, Joker }
class Program
{
    static void Main(string[] args)
    {
        ConsoleColor ori_f = Console.ForegroundColor;
        string 顏色 = "未知顏色";
        撲克牌花樣 trumps;
        Console.WriteLine();
        // fix #3 執行此程式, 看會如何?
        // fix #4 將下一行的 梅花 改成 鑽石   再執行此程式, 看會如何?
        // fix #6 將下一行的 鑽石 改成 Joker   再執行此程式, 看會如何?
        trumps = 撲克牌花樣.梅花;
        Console.Write("trumps 的 撲克牌花樣 是        ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(trumps.ToString());
        Console.ForegroundColor = ConsoleColor.Green;
        switch (trumps)
        {
            // trumps 等於 撲克牌花樣.黑桃
            //  或者
            // trumps 等於 撲克牌花樣.梅花
            // 則一定是  黑色

            // fix #2
            // 請將下一行註解取消, 觀察執行的效果
            //case 撲克牌花樣.梅花:
            case 撲克牌花樣.黑桃:
                Console.ForegroundColor = ConsoleColor.DarkGray;
                顏色 = "黑色";

                break;
                // fix #5 
                //trumps 等於 撲克牌花樣.紅心
                //  或者
                //trumps 等於 撲克牌花樣.鑽石
                // 則一定是  紅色
                // 請寫在這裡

                Console.ForegroundColor = ConsoleColor.Red;
                顏色 = "紅色";

                break;
// 不是"撲克牌花樣.黑桃"
// , 也不是"撲克牌花樣.梅花", 也不是"撲克牌花樣.紅心
// , 也不是"撲克牌花樣.梅花
// 則一定是  "什麼顏色都不是"
// fix #7   
// 請將下一行註解取消
                //default:
                Console.ForegroundColor = ConsoleColor.Cyan;
                顏色 = "什麼顏色都不是";
                break;
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(" 它是 ");
        Console.WriteLine("##########################");
        // fix #1 執行此程式, 看下一行會印出什麼?
        Console.WriteLine(顏色);
        Console.ForegroundColor = ori_f;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine(" 的牌");

        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}

