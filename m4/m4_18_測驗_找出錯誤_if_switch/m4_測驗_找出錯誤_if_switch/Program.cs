using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 6;
        // question #1
        //  在 number % 2 == 0 前後分別加上 ( 以及 )

        // fix #1 將下一行註解取消, 會如何?  有錯的話, 如何修正?
        // if   number % 2 == 0
        {
            Console.WriteLine("question #1 可有錯?");
        }
        Console.WriteLine();
        int percent = 108;
        // question #2
        //  在 (percent < 0) || (percent > 100)  前後分別加上 ( 以及 )

        // fix #2 將下一行註解取消, 會如何?  有錯的話, 如何修正?
        // if   (percent < 0) || (percent > 100)
        {
            Console.WriteLine("question #2 可有錯?");
        }
        Console.WriteLine(); Console.WriteLine();
        // question #4
        string color = "unknown";
        Suit trumps;
        trumps = Suit.Hearts;

        switch (trumps)
        {
            // fix #3-1 將下一行註解取消, 會如何?  有錯的話, 如何修正?
            // case Suit.Clubs,
            case Suit.Spades:
                color = "Black";
                break;
            // fix #3-2 將下一行註解取消, 會如何?  有錯的話, 如何修正?
            //    case Suit.Hearts,
            case Suit.Diamonds:
                color = "Red";
                break;
            default:
                color = "Error";

                break;
        }
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.WriteLine("question #4");
        Console.WriteLine(color);
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        int minute;
        // 幾分鐘(幾點幾分, 比如2點59分): 分鐘數應介於0到59(包含0及59)
        minute = 59;
        Console.WriteLine("##########################################");
        Console.WriteLine("minute 原為");
        Console.WriteLine(minute);
        Console.WriteLine("question #3 可有錯?");
        // question #4
        // fix #4  若分鐘數等於60, 要歸零.   下一行有錯的話, 如何修正?
        if (minute == 60) ;
          minute = 0;
        Console.WriteLine("minute 後來為");
        Console.WriteLine(minute);
        Console.WriteLine("??????????????????????????????????????????");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}
enum Suit { Clubs, Hearts, Diamonds, Spades }

