using System;

namespace m4_使用throw敘述 {
// fix #4 觀察下一行
  public class InvalidTimeException : Exception {
    public InvalidTimeException(string m)
      : base(m) 
    {
    }
  }
  class Program {
    public static int MyInputMinute() {
// fix #1 把mouse游標移到下行Parse, 會看到列出什麼例外狀況?
      int minute = int.Parse(Console.ReadLine());

      if (minute < 0 || minute >= 60)
      {
// fix #3 觀察下一行
        throw new InvalidTimeException(minute + " 不是正確分鐘數");
//若 if是 true 後面不會被執行到
      }
      return minute;
    }
    static void Main(string[] args) {
      ConsoleColor original = Console.ForegroundColor;
      Console.WriteLine("開始");
      try
      {
// fix #5 執行此程式, 
        Console.WriteLine("輸入幾點幾分的分鐘數, 我們會存到  i ");
        int 分鐘 = Program.MyInputMinute();
// fix #2 若上一行執行時, 輸入的整數小於 0 或大於或等於 60
//         則丟出InvalidTimeException例外
//         , 而在try { } 中剩下的敘述不會執行
//         程式流程會轉而去執行catch (InvalidTimeException caught) 的 { }
//         , 執行完catch (InvalidTimeException caught) 的 { }後
//         會從catch (InvalidTimeException caught) 的 { }後的
//          Console.WriteLine();Console.WriteLine("結束");
//          繼續往後執行
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("minute 為  " + 分鐘 + " 分");
        Console.ForegroundColor = original;
      }
      catch (InvalidTimeException caught)
      {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();
        Console.WriteLine("從 XXX 教室: ");
        Console.WriteLine("     " + caught.Message);
        Console.WriteLine("到 XXX 教室");
        Console.WriteLine();
        Console.ForegroundColor = original;
      }
      Console.WriteLine(); Console.WriteLine("結束");
      Console.WriteLine("The end");
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
