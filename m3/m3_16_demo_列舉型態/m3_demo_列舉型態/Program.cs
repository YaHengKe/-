using System;

using System.Windows.Forms;

namespace m3_demo_列舉型態
{
  enum 撲克牌花樣 { 黑桃 , 紅心 , 鑽石 , 梅花 }
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleColor ori_f = Console.ForegroundColor;
      int ws;
      ws = 3;
      Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
      switch( ws )
      {
          case 3:
              Console.ForegroundColor = ConsoleColor.Yellow;
              Console.WriteLine(ws);
              Console.ForegroundColor = ori_f;
              break;
          case 0:
              Console.ForegroundColor = ConsoleColor.Red;
              Console.WriteLine(ws);
              Console.ForegroundColor = ori_f;
              break;
          case 1:
              Console.ForegroundColor = ConsoleColor.Green;
              Console.WriteLine(ws);
              Console.ForegroundColor = ori_f;
              break;
          case 2:
              Console.ForegroundColor = ConsoleColor.Blue;
              Console.WriteLine(ws);
              Console.ForegroundColor = ori_f;
              break;
      }
      Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
      Console.WriteLine();
      String s = "啥";
// 設定enum型態變數的內容
// fix #1 請觀察下兩行, 若你用 Ctrl + F5 來執行, 觀察完, 再請用講師告訴你的方式結束此程式
      MyColor bkColor =  MyColor.Red;
      s = bkColor.ToString();
      Console.WriteLine("??????????????????????????????");
// fix #2 請回答下行會印出什麼?
      Console.WriteLine( s );//顯示Red
      Console.WriteLine("##############################");
      Console.WriteLine();
      Console.WriteLine("實例");
// System.Windows.Forms 名稱空間
      FormBorderStyle fs;
// fix #5 請將下一行  的 Fixed3D 改成    None
//         再 觀察會如何?
// fix #3 請觀察下一行
      fs =  FormBorderStyle.Fixed3D;
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
      Console.WriteLine(fs.ToString());
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Form R1 = new Form();
// fix #4 請觀察下一行
      R1.FormBorderStyle = fs;
      Console.WriteLine();
      Console.WriteLine();
      Console.WriteLine();
      Application.Run(R1);
     
    }
  }
  //定義enum型態 , 型態名稱為 MyColor
  enum MyColor { Red, Green, Blue, Yellow }

}
