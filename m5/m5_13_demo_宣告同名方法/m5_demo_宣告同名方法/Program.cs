using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace m5_demo_宣告同名方法 {
  class Program {
// fix #2 將下面的方法註解
    static int Add(int c, int d) {
      return c + d;
    }
    static int Add(int a, int b) {
      return a + b;
    }
    static int Add(int a, int b, int c) {
      return a + b + c;
    }
    static void Main(string[] args) {
      Console.WriteLine();
// fix #1 觀察下面程式執行的情形
      Console.WriteLine( Program.Add(1, 2) ); 
      Console.WriteLine("############################");
// fix #3 觀察下面程式執行的情形
      Console.WriteLine( Program.Add(5, 8, 4) );
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
