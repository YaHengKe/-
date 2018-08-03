using System;
// fix  #0   觀察下兩行
using System.Collections;
using System.Collections.Generic;

namespace module6_測驗_Generic集合與傳統的集合 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;
      Console.WriteLine();
// fix  #3   執行後觀察會怎什麼樣?
      Console.WriteLine("傳統的");
      {
// fix  #1   觀察下一行的需求
// 我們想要一個System.Collections.ArrayList的物件
//, 但希望它的元素都是 int 型態
        ArrayList myList = new ArrayList(); 
        myList.Add(5); // 需要Boxing 
// fix #4
//     取消下一行註解, 執行後觀察會怎什麼樣?
//                   觀察完恢復成註解
        // myList.Add(false);  
        myList.Add(3);
        Console.WriteLine("?????????????????????????????????????????????????");
        for (int i = 0; i < myList.Count; i += 1)
        {
          int en;
// fix #2
//     註解下一行的 (int) 部分, 會怎什麼樣? 有無語法錯誤?
//                   觀察完取消註解
          en = (int)(myList[i]);  // 需轉型
          Console.WriteLine("myList[" + i + "] 為 " + en);
        }
      }
      Console.WriteLine("#################################################");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("泛型Generic的寫法");
      Console.ForegroundColor = original;
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
      {
// fix  #5   觀察下一行的需求
// 我們想要一個類似ArrayList的物件, 但希望它的元素都是int型態
        List<int> myList = new List<int>();  

        myList.Add(5); // 不需要Boxing //提升應用程式效能
// fix #6
//      取消下一行註解, 會怎什麼樣? 有無語法錯誤?
//                  觀察完恢復成註解
        // myList.Add(false); // 編譯時期進行型別檢查
        myList.Add(3);
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
        Console.ForegroundColor = ConsoleColor.Red;
        for (int i = 0; i < myList.Count; i += 1)
        {
          int en;
// fix #7
//  觀察下一行的(int)改成/* (int) */也就是變成註解,會怎什麼樣?有無語法錯誤?
          en = /* (int) */(myList[i]); //(int)(myList[i]);   // 不需轉型
          Console.WriteLine("myList[" + i + "] 為 " + en);
        }
        Console.ForegroundColor = original;
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
      }
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("結束     ");
      Console.ForegroundColor = original;
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
