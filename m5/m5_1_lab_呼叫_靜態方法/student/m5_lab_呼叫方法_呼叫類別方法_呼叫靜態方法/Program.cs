using System;
namespace m5_lab_呼叫類別方法_呼叫靜態方法 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor ori = Console.ForegroundColor; Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("開始");Console.ForegroundColor = ori;
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
// fix #3 先執行此程式, 看會如何? 
// fix #4 將下一行中的註解取消   再執行此程式, 看會如何? 
/*     呼叫靜態方法   */
      //A.S();
      Console.WriteLine("????????????????????????????????????????????????");
// fix #5 將下一行中的註解取消   再執行此程式, 看會如何? 
/*  呼叫類別方法   呼叫靜態方法   */
      //A.S();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("################################################");
      Console.ForegroundColor = ori;Console.WriteLine("結束"); Console.WriteLine();
      Console.WriteLine();Console.WriteLine(); Console.WriteLine();
    }
  }
// fix #2 觀察下面名稱為 S 的 static 方法, 發明在此 A 類別中
  class A /*  類別名稱 */
  {
// fix #1 觀察下一行, 為一個 static 方法, 名稱為 S 沒有參數
//   void 代表沒有設計傳回值
    public static void S /*  方法名稱  */ ( /*  沒有參數  */  ) {
      ConsoleColor ori = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("A.S() 被呼叫了");
      Console.WriteLine("準備返回了");
      Console.ForegroundColor = ori;
    }
  }

}
