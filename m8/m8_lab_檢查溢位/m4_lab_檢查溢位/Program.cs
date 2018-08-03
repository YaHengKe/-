using System;


namespace m4_lab_檢查溢位 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;
      int max;
      Console.WriteLine();
      Console.WriteLine("############################################");
      Console.ForegroundColor = ConsoleColor.Green;
      {
        Console.WriteLine("一般來說");
        Console.WriteLine("綠色");
        max = int.MaxValue;
        Console.WriteLine("max 原本為 " + max);
        max++;
        Console.WriteLine("max 後來為 " + max);
      }
      Console.ForegroundColor = original;
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
// fix #1 執行此程式,   看會如何?
// fix #2 將下三行的 註解取消   看會如何?
      //Console.ForegroundColor = ConsoleColor.Yellow;
      //Console.WriteLine("checked  區段");
      //checked
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("黃色");
        max = int.MaxValue;
        Console.WriteLine("max 原本為 " + max);
        max++;
        Console.WriteLine("max 後來為 " + max);
      }
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("????????????????????????????????????????????");
      Console.WriteLine("結束");
      Console.ForegroundColor = original;
      Console.WriteLine(); Console.WriteLine();
      Console.WriteLine(); Console.WriteLine();
    }
  }
}
