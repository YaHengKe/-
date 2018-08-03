using System;
class Program
{
    static void TheDemo(out int p)
    {
// fix #2 取消下行註解, 會發生什麼事? 觀察後恢復註解
        // p = p + 1;
// fix #3 將下行註解, 會發生什麼事? 觀察後取消註解
        p = 5 ;
    }
    static void Main(string[] args)
    {
        Console.WriteLine();
        int n;
        // fix #4 可否擦掉下一行的 out ?
        Program.TheDemo( out  n  );
        Console.WriteLine("????????????????????????????????????????");
        // fix #1 觀察會印出什麼?
        Console.WriteLine( n ); //顯示 5
        Console.WriteLine("########################################");
        Console.WriteLine();
        Console.WriteLine(); 
        Console.WriteLine();
    }
}
