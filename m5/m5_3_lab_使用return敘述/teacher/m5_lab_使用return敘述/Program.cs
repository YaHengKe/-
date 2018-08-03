using System;

namespace m5_lab_使用return敘述 {
  class Program {
    public static void 壯志未酬() {
      ConsoleColor original = Console.ForegroundColor;
      Random Rm = new Random();
      int NB = (int)(Rm.NextDouble() * 20);
      Console.WriteLine("使得當 NB 大於或等於 10 , 才印出bla bla");
      Console.Write("NB 為 ");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(NB);
      if (NB < 10)
// fix #1  如何修改下一行, 使得當 NB 大於或等於 10 時, 才印出如下:
//破匈奴
//中間
        return;
      Console.WriteLine("破匈奴");
      Console.WriteLine("中間");
    }
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("準備呼叫   Program.壯志未酬( )");
      Console.WriteLine("???????????????????????????????????????????");
      Console.ForegroundColor = original;
// fix #2 觀察做到沒?
      Program.壯志未酬();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("###########################################");
      Console.WriteLine("呼叫完     Program.壯志未酬( )");
      Console.ForegroundColor = original;
      Console.WriteLine(); Console.WriteLine();
      Console.WriteLine(); Console.WriteLine();
      Console.WriteLine(); Console.WriteLine();
      Console.WriteLine();
    }
  }
}
