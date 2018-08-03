using System;

// fix #1 觀察下一行
using System.Collections;

namespace m4_lab_foreach敘述 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;
      Console.WriteLine();
      Console.WriteLine("System.Collections.ArrayList lots = new ArrayList();");
// fix #2 觀察下一行
      System.Collections.ArrayList lots = new ArrayList();
      Console.WriteLine("加入元素前");
      Console.WriteLine("foreach  開始");
            // fix #3  將下面foreach敘述的註解取消,  觀察什麼語法的錯誤? 
            // fix #4  修正 下面foreach敘述的語法的錯誤, 亦即將 NB 和 lots 中間加個 in
            //          修正 錯誤後, 再執行, 觀察下面foreach能達到什麼效果? 
            //            應該沒有效果, 因為還沒有加任何元素到ArrayList
            ArrayList ArrL = new ArrayList();

            foreach (int NB  in lots)
            {
                Console.Write(NB);
                Console.Write(" ");
            }

            Console.WriteLine();
      Console.WriteLine("foreach  結束");
      Console.WriteLine("?????????????????????????????????????????????????");
      Console.WriteLine();
      Console.WriteLine("加入元素進行中...");
      Console.WriteLine();
      for (int i = 0; i < 10; i++)
      {
// fix #5 觀察下一行
        lots.Add(i);
      }
      Console.WriteLine();
      Console.WriteLine("加入元素後");
      Console.WriteLine("#################################################");
      Console.ForegroundColor = ConsoleColor.Red;
// fix #6 觀察下面 foreach會印出什麼?
      foreach (int number in lots)
      {
// fix #7  將下一行的註解取消,  觀察有什麼語法的錯誤?
        // number = 10; // 無法指派給 'number'，因為它是 'foreach 反覆運算變數'(唯讀)
        Console.Write(number);
        Console.Write(" ");
      }
      Console.WriteLine();
      Console.ForegroundColor = original;
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
