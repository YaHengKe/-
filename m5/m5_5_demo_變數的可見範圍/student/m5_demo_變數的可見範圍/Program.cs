using System;
  class Program {
    static void S() {
      ConsoleColor original = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Green;
      //宣告在方法中的變數
      //只能為宣告變數的方法所用
      int T = 0;/* 可見範圍由此開始  */
      T += 2;
      Console.WriteLine("在 Program.S( )內 T 為 " + T);
      Console.ForegroundColor = original;
    /* 可見範圍在此結束  */}
    static void Main(string[] args)
    {
        {
            // fix #1 執行此程式, 看會如何?
            // fix #2 將下行註解取消, 再執行此程式, 看會如何?
            /* int T = 1; */
            Console.WriteLine("可見範圍開始 T 為 " + T);
            Program.S();
            Console.WriteLine("???????????????????????????????");
            // 下行可能會語法錯誤
            /*  這不是 Program.S( ) 內的區域變數 */
            if (T >= 2)
            {
                Console.WriteLine("World");
            }
            Console.WriteLine("###############################");
            Console.WriteLine("可見範圍結束");}
      //Console.WriteLine("此處 T 為 " + T);
      Console.WriteLine(); Console.WriteLine();
      Console.WriteLine();
    }
  }

