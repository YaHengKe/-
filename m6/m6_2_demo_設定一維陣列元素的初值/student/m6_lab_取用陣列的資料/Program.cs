using System;
namespace m6_lab_取用陣列的資料 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor origin = Console.ForegroundColor;
      Console.WriteLine();
      Console.WriteLine("設定陣列元素的初值");
      Console.WriteLine("#########################################");
      {
        long[] row = new long[4] { 9, 4, 2, 7 };

        for (int i = 0; i < row.Length; i++)
        {
          Console.WriteLine("row[" + i + "]  為 " + row[i]);
        }
      }
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.WriteLine(); 
      Console.WriteLine("設定陣列元素的初值_簡寫");
      {
// fix #2 你可將下行改成 long[] row =  { 3, 5, 6, 8 };
//  宣告存陣列物件的變數時, 可用簡寫
        long[] row = new long[4] { 3, 5, 6, 8 };
        Console.WriteLine("?????????????????????????????????????????");
        Console.ForegroundColor = ConsoleColor.Yellow;
// fix #1  下面會印出什麼?
        for (int i = 0 ; i < row.Length ; i++ )
        { 
          Console.WriteLine("row[" + i + "]  為 " + row[i]);
        }
        Console.ForegroundColor = origin;
      }
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
      Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
      Console.WriteLine();
    }
  }
}
