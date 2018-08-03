using System;
class Program
{
    // fix #2 觀察下一行
    //  請問這是宣告區域變數嗎? 答案: 否
    // 如果不是,  
    //  練習 #1 想用的區域變數 P 的宣告該寫在哪裡? 
    //  請繼續做 練習 #3 就知道如何宣告
    int P;

    static void Main(string[] args)
    {

        // fix 練習 #3
        // 宣告 以及 指派變數 P 的內容值   為  23.5 
        // (宣告區域變數, 區域變數為宣告在方法裡的變數
        //  而 Main 就是一個方法 )
        // 請寫在下一行
        

        Console.WriteLine("?????????????????????????");
        // fix 練習 #1 執行此程式, 會如何?
        // 將變數 P 的內容值印出來 // 已寫在下一行
        float ft = 26.5F;
        Console.WriteLine(ft);
        int P=3;
        Console.WriteLine(P);

        Console.WriteLine("#########################");
        Console.WriteLine();
        // fix #4 觀察下面
        int FN;
        FN = 23;
        Console.WriteLine("?????????????????????????");
        Console.WriteLine(FN);
        Console.WriteLine("#########################");
        int YP = 98;
        Console.WriteLine(YP);
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@");
        char MT = 'K';
        Console.WriteLine(MT);
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

