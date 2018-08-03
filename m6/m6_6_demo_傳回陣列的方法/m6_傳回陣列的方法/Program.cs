using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace module6_傳回陣列的方法 {
  class Program {
    static int[] CreateArray(int size) {
      int[] created = new int[size];
      return created;
    }
    public static void Main() {
      ConsoleColor original = Console.ForegroundColor;
      Console.WriteLine();
      int[] array = null;
      array = Program.CreateArray(42);
      Console.WriteLine("array 參考到的陣列的 元素個數  為 ");
      Console.WriteLine("????????????????????????????????????");
      Console.ForegroundColor = ConsoleColor.Red;
// fix  測驗題目 #1    下一行會印出什麼?
      Console.WriteLine(array.Length);

      Console.ForegroundColor = original;
      Console.WriteLine("####################################");
      Console.WriteLine();
      Console.WriteLine("結束");
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
