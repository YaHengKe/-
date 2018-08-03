using System;

using System.Text;

namespace m7_String類別與StringBuilder類別 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor originalForeGrd = Console.ForegroundColor;
      Console.WriteLine("String類別  其內容不可以改變");
      {
        string sb = "Hello";
        Console.WriteLine("?????????????????????????????????????????????????????????????");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(sb[0]);
        Console.ForegroundColor = originalForeGrd;
        Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
// fix #1  執行此程式, 觀察會如何?
// fix #2  請將下行註解, 觀察會如何?
        sb[0] = 'C';
        Console.WriteLine("sb.ToString() 為 ");
        Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(sb.ToString());
        Console.ForegroundColor = originalForeGrd;
        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
      }
      Console.WriteLine("StringBuilder類別 - 內容值可以改變的字串");
      {
        StringBuilder sb = new StringBuilder("Hello");
        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
        Console.ForegroundColor = ConsoleColor.Yellow;
// fix #3  執行此程式, 看下行印出的效果
        Console.WriteLine(sb[0]);
        Console.ForegroundColor = originalForeGrd;
        Console.WriteLine("#############################################################");
// fix #5  下行語法是對的, 請取消其註解, 再看執行此程式印出的效果
        //sb[0] = 'C';
        Console.WriteLine("sb.ToString() 為 ");
        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        Console.ForegroundColor = ConsoleColor.Yellow;
// fix #4  執行此程式, 看下行印出的效果
        Console.WriteLine(sb.ToString());
        Console.ForegroundColor = originalForeGrd;
// fix #7  下行語法是對的, 請取消其註解, 再看執行此程式的效果
        // sb.Append(" 是大提琴");
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("sb.ToString() 為 ");
        Console.WriteLine("*************************************************************");
        Console.ForegroundColor = ConsoleColor.Yellow;
// fix #6  執行此程式, 看下行印出的效果
        Console.WriteLine(sb.ToString());
        Console.ForegroundColor = originalForeGrd;
      }
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.WriteLine("若你有需要常常改變字串的內容值,  請使用StringBuilder類別");
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}
