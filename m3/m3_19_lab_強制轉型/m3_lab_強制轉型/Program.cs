using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("??????????????????????????????????????????????????????????????????????");
        // fix #1 觀察下一行可有問題?
        //         若有問題, 請用轉型運算 
        //         ,將 double型態的值 20.5轉型成 float型態的值
        //         , 就能將此轉換型態後的值, 存到 fValue 變數內
        float fValue =  (int)20.5; // 20.5  為 double 型態的值

        Console.Write("fValue 為 ");
        Console.WriteLine(fValue);
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();
        Console.WriteLine("實例");
        Console.WriteLine("######################################################################");
        Random am = new Random();
        double DD;
        int RN;

        DD = am.NextDouble();
        Console.WriteLine("DD        為 " + DD         );
        Console.WriteLine("(DD * 10) 為 " + (DD * 10)  );
        // fix #2 若將下一行轉型運算(int)去掉
        //          ,   觀察下一行可有問題?         
        RN = (int)(DD * 10) ; // (DD * 10)  為 double 型態的值
        Console.WriteLine("RN 為 " + RN);
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        DD = am.NextDouble();
        Console.WriteLine("DD        為 " + DD);
        Console.WriteLine("(DD * 10) 為 " + (DD * 10));       
        RN = (int)(DD * 10); // (DD * 10)  為 double 型態的值
        Console.WriteLine("RN 為 " + RN);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

