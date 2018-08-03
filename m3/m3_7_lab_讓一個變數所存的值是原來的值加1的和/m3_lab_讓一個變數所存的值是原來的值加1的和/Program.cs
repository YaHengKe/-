using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        int X;
        // 指派變數 X 的內容值 為  比3來的大, 但比6來的小
        // 已寫在下一行
        X = 4 + ((int)(new Random().NextDouble() * 2));
        Console.WriteLine();
        Console.WriteLine("X 的內容值 原本為 ");
        Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        Console.ForegroundColor = ConsoleColor.Yellow;
        //fix #1 觀察下一行 將變數 X 的內容值印出來 
        Console.WriteLine(X);
        Console.ForegroundColor = original;
        Console.WriteLine("########################################################");
        // fix #3 如何用遞增讓 X 這個變數所存的值是原來的值加1 的和? 請寫在下一行


        Console.WriteLine("讓 X 這個變數所存的值是原來的值加1的和  後");
        Console.WriteLine();
        Console.WriteLine("X 的內容值 變為");
        Console.WriteLine("????????????????????????????????????????????????????????");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #2 觀察下一行, 將變數 X 的內容值印出來
        Console.WriteLine(X);
        Console.ForegroundColor = original;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        //      優先順序
        //例如 48 + 12 * 4
        //此例為先算 12 * 4 後算 48 + 48
        // fix #4 將下一行註解取消, 觀察下一行會印出什麼?
        //Console.WriteLine(48 + 12 * 4);
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        // 結合性
        //例如 48 / 12 / 4
        //      此例為先算 48 / 12 後算 4 / 4
        // fix #5 將下一行註解取消, 觀察下一行會印出什麼?
        //Console.WriteLine(48 / 12 / 4);
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
        //使用小括號
        //     例如 48 / (12 / 4)
        //     此例為先算 12 / 4 後算48 / 3
        // fix #6 將下一行註解取消, 觀察下一行會印出什麼?
        //Console.WriteLine( 48 / (12 / 4) );
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        int NK;
        NK = 32;
        // fix #7  如何在下一行寫程式能 印出 NK 為 32

        Console.WriteLine();
        float AT;
        // fix #8  將下兩行註解取消, 如何修正下一行 能將 8.5 存進 AT 這個 float 型態的變數
        //AT = 8.5;
        //Console.WriteLine(AT);
        Console.WriteLine("********************************************************");
        Console.WriteLine();
    }
}

