using System;
namespace module6_測驗_找出程式碼的錯誤_array {
  class Program {
    static void Main(string[] args) {
      ConsoleColor origin = Console.ForegroundColor;
      Console.WriteLine();
// fix  #0 執行此程式, 看會如何?
      Console.WriteLine("測驗題目: #1  ");
      {
        int[] array;
        Console.Write("");
        //
// fix 測驗題目: #1  
// 取消下一行的註解, 會有問題嗎? 如何改善?
         array = new int[4] { 0, 2, 4, 6 };
        Console.WriteLine("過關");
      }
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("測驗題目: #2  ");
      Console.ForegroundColor = origin;
      {
        int[] array;
// fix 測驗題目: #2
// 註解下一行, 會有問題嗎? 觀察完取消此註解
        array = new int[1];
        System.Console.WriteLine(array[0]);
        Console.WriteLine("過關");
      }
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("測驗題目: #3  ");
      Console.ForegroundColor = origin;
      {
        int[] array = new int[3];
        //
// fix 測驗題目: #3  
// 取消下一行的註解, 會有問題嗎? 如何改善?
        System.Console.WriteLine(array[2]);
        Console.WriteLine("過關");
      }
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("測驗題目: #4  ");
      Console.ForegroundColor = origin;
      {
        //
// fix 測驗題目: #4  
// 取消下一行的註解, 會有問題嗎? 如何改善?
         int[] array = new int[3];
        Console.WriteLine("過關");
      }
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("測驗題目: #5  ");
      Console.ForegroundColor = origin;
      {
        //
// fix 測驗題目: #5  
// 取消下一行的註解, 會有問題嗎? 如何改善?
        int[] array = new int[4] { 0, 1, 2, 3 };
        Console.WriteLine("過關");
      }
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
