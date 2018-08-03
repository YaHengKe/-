using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("開始");
        Console.WriteLine();
        String cn;
        Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&");
        // fix #2 將下一行 325 改成 ktm 觀察可有問題?
        cn = "325";
        Console.Write("cn 為  ");
        Console.WriteLine(cn);
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
        int RG;
        // fix #1 觀察下一行可有問題?
        //         若有問題, 請不要用轉型運算 
        //     而是改 (int)cn 為 int.Parse(cn)
        RG = int.Parse(cn);
        Console.WriteLine("##########################");
        Console.Write("RG 為  ");
        Console.WriteLine(RG);
        Console.WriteLine("??????????????????????????");
        Console.WriteLine();
        Console.WriteLine("結束");
        Console.WriteLine();
        Console.WriteLine();




    }
}

