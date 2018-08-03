using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("開始");
        Console.WriteLine();
        String cn;
        // fix #2 將下一行 325 改成 ktm 觀察可有問題?
        cn = "325";
        bool 成功;
        int Age;
        // fix #1 觀察下一行可有問題?
        //         若有問題, 請
        //     在 Age 前加一個 out 保留字
        成功 = int.TryParse(cn, out    Age);

        Console.WriteLine("??????????????????????????????????");
        if (成功)
        {
            Console.WriteLine(Age + 1);
        }
        else
        {
            Console.WriteLine("轉型不成功");
        }
        Console.WriteLine("##################################");
        Console.WriteLine();
        Console.WriteLine("結束");
        Console.WriteLine();
        Console.WriteLine();
    }
}

