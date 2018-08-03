using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        // fix #1 觀察下一行
        float fValue = 123.5f; // 123.5f  為 float 型態的值

        // 將float型態的變數內的值轉型成double型態的值,再將此轉換型態後的值
        //   , 存到dValue變數內
        // fix #2 觀察下一行可有問題?
        double dValue = fValue;

        fValue = -98.4f;
        Console.WriteLine("????????????????????????");
        // fix #3 觀察下一行
        Console.WriteLine(fValue);
        Console.WriteLine("########################");
        // fix #4 觀察下一行
        Console.WriteLine(dValue);
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

