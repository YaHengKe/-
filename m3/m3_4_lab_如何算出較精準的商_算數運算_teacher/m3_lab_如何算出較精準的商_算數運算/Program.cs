using System;
class Program {
    static void Main(string[] args) {
        ConsoleColor ori = Console.ForegroundColor;
        double k;
        // fix #1 觀察下一行, 將變數 k 的內容值設為 2.5 已寫在下一行
        k = 2.5;
        Console.WriteLine("k 變數所存的內容值   為");
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // fix #2 觀察下一行會印出什麼? 將變數 k 的內容值印出來
        Console.WriteLine(k);
        Console.ForegroundColor = ori;
        Console.WriteLine("########################################################");
        Console.WriteLine("讓拾的值當被除數  ");
        Console.WriteLine("讓四的值當除數    ");
        Console.WriteLine();
        Console.WriteLine("除出來的商 存到 k 變數內");
        Console.WriteLine();
        // fix #5   如何修改下一行讓k變數所存的內容值是較為精準的商的值
        // fix #3 觀察下一行
        k = 10 / 4.0 ;
        Console.WriteLine("k 變數所存的內容值是較為精準的商的值  為");
        Console.WriteLine("????????????????????????????????????????????????????????");
        Console.ForegroundColor = ConsoleColor.Red;
        //fix #4  觀察下一行會印出什麼? 將變數 k 的內容值印出來 
        Console.WriteLine(k);
        Console.ForegroundColor = ori;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

