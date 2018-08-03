using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m3_lab_如何讓一個變數所存的內容值是原來的兩倍的值
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleColor original = Console.ForegroundColor;
      int itemCount;
// 指派變數itemCount的內容值 為  比3來的大, 但比6來的小
// 已寫在下一行
      itemCount = 4 + ((int)(new Random().NextDouble() * 2));
      Console.WriteLine("itemCount的內容值 原本為");
      Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
      Console.ForegroundColor = ConsoleColor.Yellow;
// 將變數itemCount的內容值印出來
// 已寫在下一行
// fix #1 觀察下一行
      Console.WriteLine(itemCount);
      Console.ForegroundColor = original;
      Console.WriteLine("########################################################");
// fix #3
// 如何用遞增讓 itemCount這個變數所存的值是原來的值加1的和
//  請寫在下一行 ( 不要寫成 itemCount = itemCount + 1   或者   itemCount += 1 )

      Console.WriteLine();
      Console.WriteLine("讓itemCount這個變數所存的值是原來的值加1的和  後");
      Console.WriteLine();
      Console.WriteLine("itemCount的內容值 變為");
      Console.WriteLine("????????????????????????????????????????????????????????");
      Console.ForegroundColor = ConsoleColor.Red;
// 將變數itemCount的內容值印出來
// 已寫在下一行
// fix #2 觀察下一行
      Console.WriteLine(itemCount);
      Console.ForegroundColor = original;
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
