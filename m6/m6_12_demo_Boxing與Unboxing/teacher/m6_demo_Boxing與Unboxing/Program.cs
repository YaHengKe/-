using System;
using System.Collections.Generic;

using System.Collections;

namespace m6_demo_Boxing與Unboxing {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine();
      ArrayList myList = new ArrayList();
      int p = 2;
      int q = 2;
//存物件參考值的變數
      object box = null;
// fix #1 觀察下一行
// 因 object 就是 System.Object 類別
// , 此類別型態的變數可存任何物件參考
// , 而且 它 是參考型態
      box = null; // null 為無效的參考
// fix #2 觀察下一行
      box = p;       // 發生boxing
// fix #3 觀察下一行 Add 的引數型態
      myList.Add(box);
// fix #4 觀察下一行
      myList.Add(q); // 發生boxing
// fix #5 觀察下一行
      int k = /* 必須強制轉型, 此時發生Unboxing */(int)box;
// fix #6 修改下一行, 將   (int)(myList[1])  改成 (myList[1])
// 可有問題? 若有問題, 請改回來
      int m = (int)(myList[1]);//必須轉型,發生Unboxing
      Console.WriteLine("######################");
// fix #7 觀察下一行, 並執行此程式, 看可有問題?
      Console.WriteLine(k + m);
// fix #8 將下一行註解取消, 並執行此程式, 觀察可有問題?
      Console.WriteLine(box + myList[1]);
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$");
      Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
      Console.WriteLine();
    }
  }
}
