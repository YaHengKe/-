using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine();
        ConsoleColor original = Console.ForegroundColor;
        int itemCount;
        // 指派變數itemCount的內容值 為  比3來的大, 但比6來的小
        // 已寫在下一行
        itemCount = 4 + ((int)(new Random().NextDouble() * 2));
        Console.WriteLine("itemCount的內容值 原本為");
        Console.ForegroundColor = ConsoleColor.Yellow;
        // fix #1 觀察下一行, 將變數itemCount的內容值印出來
        Console.WriteLine(itemCount);
        Console.ForegroundColor = original;
        Console.WriteLine("########################################################");
        // fix #3 如何讓itemCount變數所存的內容值是原來的兩倍的值?
        //   請寫在下一行, 請練習用複合指派
        itemCount *= 2;
        Console.WriteLine("讓itemCount變數所存的內容值是原來的兩倍的值  後"+itemCount);
        Console.WriteLine();
        Console.WriteLine("itemCount的內容值 變為");
        Console.ForegroundColor = ConsoleColor.Red;
        // fix #2 觀察下一行, 將變數itemCount的內容值印出來
        Console.WriteLine(itemCount);
        Console.ForegroundColor = original;
        Console.WriteLine("????????????????????????????????????????????????????????");
        Console.WriteLine();
        Console.WriteLine();
    }
}
