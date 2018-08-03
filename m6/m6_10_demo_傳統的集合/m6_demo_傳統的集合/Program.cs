using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;

namespace m6_demo_傳統的集合 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;
    string str = "ktm";
    // fix #1 觀察下一行 object 是什麼? Any 變數可設成 null 無效參考
    object Any = null;
    // fix #2 觀察下一行
    Any = str;
    // fix #3 觀察下一行 boxing
    Any = 8.5;
    // fix #4 觀察下一行 boxing
    Any = false;
    // fix #5 觀察下一行 boxing
    Any = 95;
      Console.WriteLine();
      System.Collections.ArrayList myList = new System.Collections.ArrayList();
      Console.WriteLine("######################################");
      Console.Write("原來有 ");
      Console.ForegroundColor = ConsoleColor.Green;
// fix #6 下一行會印出什麼?
      Console.Write(myList.Count);
      Console.ForegroundColor = original;
      Console.WriteLine(" 個元素");
      Console.WriteLine("??????????????????????????????????????");
      // fix #7 觀察下兩行
      myList.Add(95);    //加入元素
      myList.Add(67);    //加入元素
      //集合可以存放型態不同的資料, 而且元素數目可以改變
      Console.Write("目前有 ");
      Console.ForegroundColor = ConsoleColor.Magenta;
// fix #8 下一行會印出什麼?
      Console.Write(myList.Count);
      Console.ForegroundColor = original;
      Console.WriteLine(" 個元素");
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
// fix #9 觀察下一行
      myList.Add(false);  //加入元素
      Console.Write("最後有 ");
      Console.ForegroundColor = ConsoleColor.Yellow;
// fix #10 下一行會印出什麼?
      Console.Write(myList.Count);
      Console.ForegroundColor = original;
      Console.WriteLine(" 個元素");
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
