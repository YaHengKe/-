using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m5_lab_傳回執行結果 {
  class Program {
    static void NA() {
      ConsoleColor ori = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine();
      Console.WriteLine("NA( )被呼叫");
      Console.WriteLine();
      Console.ForegroundColor = ori;
    }
    static int Tu() {
      ConsoleColor ori = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine();
      Console.WriteLine("Tu( )被呼叫");
      Console.WriteLine();
      Console.ForegroundColor = ori;
// fix #3  觀察如何傳回一個值
      return 68;
    }
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;
      int RV = -5;
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("開始 RV  為 " + RV);
      Console.ForegroundColor = original;
// fix #1 觀察執行此程式會發生什麼事? 再將下一行註解
      //RV = Program.NA( );
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
// fix #2 取消下一行註解, 會發生什麼事?
      Program.NA( );
      Console.WriteLine("???????????????????????????????????????????????");
// fix #4 取消下一行註解, 會發生什麼事?
      Program.Tu( );
      Console.WriteLine("###############################################");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("中間 RV  為 " + RV);
      Console.ForegroundColor = original;
      Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
// fix #6 取消下一行註解, 會發生什麼事?
       RV = Program.Tu( );
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write("結束 RV  為 ");
// fix #5 觀察下一行會印出什麼?
      Console.WriteLine(RV);
      Console.ForegroundColor = original;
      Console.WriteLine();Console.WriteLine();Console.WriteLine();
      Console.WriteLine();
    }
  }
}
