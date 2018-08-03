using System;

namespace m4_多個catch區段 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor 原前景色 = Console.ForegroundColor;
      Console.WriteLine("開始");
      try
      {
// fix #2 執行此程式
          Console.WriteLine("輸入一個介於 "
            + int.MinValue + " 到 " + int.MaxValue + " 的一個整數");
        Console.WriteLine(", 我們會存到  i ");
        String str;
        str = Console.ReadLine();
// fix #1 把mouse游標移到下行Parse, 會看到列出什麼例外狀況?
        int i = int.Parse(str);
// fix #3 若上一行執行時, 輸入的不是整數
//
//         , 而在try { } 中剩下的敘述不會執行
//         程式流程會轉而去執行catch (Exception caught) 的 { }
//         , 執行完catch (Exception caught) 的 { }後
//         會從catch (Exception caught) 的 { }後的
//          Console.WriteLine();Console.WriteLine("結束");
//          繼續往後執行

        Console.WriteLine("i + 1 為  " + (i + 1));
        int j = (int)(new Random().NextDouble() * 2);
        Console.WriteLine("j 為 " + j);
        int k = i / j;
        Console.WriteLine("i / j 為 " + k);

      }
      catch (OverflowException caught)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine();
        Console.WriteLine("從 304 教室: ");
        Console.WriteLine(caught.Message);
        Console.WriteLine("到 304 教室");
        Console.WriteLine();
        Console.ForegroundColor = 原前景色;
      }
      catch (DivideByZeroException caught)
      {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();
        Console.WriteLine("哈哈, 居然: " + (caught.Message) + " :哈哈");
        Console.WriteLine();
        Console.ForegroundColor = 原前景色;
      }
      catch (Exception caught)
      {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("能 catch父類別例外以及子類別例外: ");
        Console.WriteLine("    " + caught.Message);
        Console.WriteLine("能 catch父類別例外以及子類別例外");
        Console.WriteLine();
        Console.ForegroundColor = 原前景色;
      }
      Console.WriteLine(); Console.WriteLine("結束");
      Console.WriteLine("The end");
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
