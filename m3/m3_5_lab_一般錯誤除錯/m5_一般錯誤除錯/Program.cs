using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5_一般錯誤除錯 {
  class Program {
    static void 方法() {// fix #5  跳離函式(按SHIFT + F11)
// fix #9
//  觀察[呼叫堆疊]視窗
      Console.WriteLine("one");
      Console.WriteLine("two");
      Console.WriteLine("three");
    }
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;
      int y = 3;
      int x = 8;
      Console.WriteLine("XXXX 教室");
// fix #0 若Project的資料夾有移動過位置
//         , 最好要做一次"建置"=>"清除方案"的動作
//         , 以免使用"偵錯"相關功能時有時會出現問題
// fix #1 設定中斷點, 將下一行設為中斷點
      Console.WriteLine("設定中斷點在此"); 
// fix #2 再按F5執行, 可讓程式中斷在中斷點的地方
// fix #3 不進入函式 (按F10)
      Program.方法();// fix #4  逐步執行(按F11)
      x = 5;
      Console.WriteLine("9");
      Console.WriteLine("8");
      Console.WriteLine("7");// fix #6 用滑鼠在此點右鍵選 執行至游標處
      // fix #7 不進入函式 (按F10)
      Program.方法();
      Console.WriteLine("#######################");
      Program.方法(); // fix #8-1 用滑鼠在此點右鍵選 執行至游標處 // fix #8-2  逐步執行(按F11)
      Console.WriteLine("???????????????????????");
      int LOCAL = 99;
// fix #10-1 用滑鼠在此點右鍵選 執行至游標處
      Console.ForegroundColor = ConsoleColor.Yellow;
// fix #10-2 觀察
//[自動變數]視窗
//[區域變數]視窗
//[監看式]視窗
//[快速監看式]功能
// 使用Data Tips
      LOCAL = LOCAL + 1;
      Console.WriteLine("LOCAL 為 " +  LOCAL);
      LOCAL = 86;
      Console.WriteLine("LOCAL 為 " + LOCAL);
      LOCAL = LOCAL + 3;  
      Console.WriteLine("LOCAL 為 " + LOCAL);
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("跑完了");
// fix #11-1 用滑鼠在此點右鍵選 執行至游標處
// fix #11-2 停止偵錯(Shift + F5)
      Console.WriteLine("不想看了");
      Console.ForegroundColor = original;
    }
  }
}
