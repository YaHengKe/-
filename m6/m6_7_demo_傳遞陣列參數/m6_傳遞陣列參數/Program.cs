using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace module6_測驗_傳遞陣列參數 {
  class Program {
    static void Method(long[] copy) {
      copy[0] = copy[0] + 1;
    }
    public static void Main() {
      ConsoleColor original = Console.ForegroundColor;
      Console.WriteLine();
      long[] row = { 13, 9, 8, 7 };
      Console.WriteLine("#######################");
      System.Console.WriteLine(row[0]);
      Console.WriteLine("???????????????????????");
      Program.Method(row);
      Console.ForegroundColor = ConsoleColor.Red;
// fix 測驗題目 #1    下一行會印出什麼?
      System.Console.WriteLine(row[0]);

      Console.ForegroundColor = original;
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$");
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }

  }
}
