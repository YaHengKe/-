using System;

class Program
{
    static void Main(string[] args)
    {
        int x;
        x = 56;
        
        Console.WriteLine("??????????????????????????");
        // fix #1 觀察下面 switch 的執行流程
        switch (x)
        {
            case -23:
                Console.WriteLine("TTYY");
                Console.WriteLine("GK");
                break;

            case 56:
                Console.WriteLine("dr");
                Console.WriteLine("wa");
                break;
        }
        Console.WriteLine("##########################");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

