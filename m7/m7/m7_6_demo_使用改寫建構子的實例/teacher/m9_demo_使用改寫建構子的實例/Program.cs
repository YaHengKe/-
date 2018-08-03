using System;

using System.IO;
namespace m7_demo_使用改寫建構子的實例 {
  class Program {
    static void Main(string[] args) {
      Random P = new Random();
      double DD = P.NextDouble();
      int K = (int)(10000 * DD);
      Console.WriteLine("begin with K == " + K);
// fix #1 執行此程式, 觀察下一行會發生什麼問題?
// fix #2 將下一行的註解取消, 再去"建置方案", 看會不會就 "建置成功"? 
      StreamWriter c1 = new StreamWriter(      "just_in_me.txt"      );
      c1.WriteLine(K + "寫到哪個檔裡去了!");// 寫到 bin/Debug/just_in_me.txt
      c1.Dispose(); 
// fix #3  執行此程式, 觀察上述訊息寫到哪裡去了?  bin/Debug/just_in_me.txt
      Console.WriteLine();
      Console.WriteLine("the end");
      Console.WriteLine();Console.WriteLine();
      Console.WriteLine();
    }
  }
}
