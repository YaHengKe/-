using System;
namespace m5_lab_呼叫類別方法_呼叫靜態方法 {
  class Program {
    static void Main(string[] args) {
      ConsoleColor ori = Console.ForegroundColor; 
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("開始");Console.ForegroundColor = ori;
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
    // fix #3 先執行此程式, 看會如何? 
    // fix #4 在下一行,在下一行,呼叫 P 類別的名稱為 X 沒有參數的靜態方法 
      
      Console.WriteLine("????????????????????????????????????????????????????????????????????");
// fix #5 在下一行,呼叫 P 類別的名稱為 X 沒有參數的靜態方法
      
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("####################################################################");
            // fix #6 在下面,呼叫 P 類別的名稱為 X 沒有參數的靜態方法 7 次
            P.X();
            P.X();
            P.X();
            P.X();
            P.X();
            P.X();
            P.X();
            P.X();
            P.X();

            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.ForegroundColor = ori;
      Console.WriteLine("結束"); 
      Console.WriteLine(); 
    }
  }
// fix #2 觀察下面名稱為 X 的 static 方法, 發明在此 P 類別中
  class P /*  類別名稱 */
  {
// fix #1 在下一行,寫一個 public 的靜態方法,沒有傳回值, 名稱為 X ,沒有參數
    
    // 此名稱為 X 的 static 方法的身體已寫好如下:
    public static void X()
    {
      ConsoleColor ori = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Red;
      P.SV += 1;
      int 積 ;
      for (int cs = 1; cs <= 9; cs++)
      {
        積 = P.SV * cs;
        Console.Write( P.SV + "x" + cs + "=");
        if( 積 < 10 )
        {
          Console.Write(" ");
        }
        Console.Write(積 + " ");
      }
      Console.WriteLine("");
      Console.ForegroundColor = ori;
    }
//靜態變數
    public static int SV = 0;
  }// end of 類別  P
  
}
