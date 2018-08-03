using System;
namespace module6_使用foreach迴圈處理陣列的元素 {
  class Program {
    static void Main(string[] G) {
      ConsoleColor original = Console.ForegroundColor;
      Console.WriteLine();
      Console.WriteLine("開始");
      Console.WriteLine("????????????????????????????????????");
      string[] args = { "Usage:", "執行檔1", "元素2", "元素3", "元素4" };
      Console.ForegroundColor = ConsoleColor.Green;
//  fix #1 觀察下面會印出什麼?
      foreach (string ET in args)
      {
        System.Console.WriteLine(ET);
      }
      Console.ForegroundColor = original;
      Console.WriteLine("####################################");
      Console.WriteLine("The end"); Console.WriteLine(); Console.WriteLine();
      Console.WriteLine(); Console.WriteLine();
      Console.WriteLine();
    }
  }
}
