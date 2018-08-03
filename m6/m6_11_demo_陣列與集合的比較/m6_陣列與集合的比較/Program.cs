using System;

using System.Collections;

namespace module6_陣列與集合的比較 {
  class Program {
    static void Main(string[] args) {
            //      ConsoleColor original = Console.ForegroundColor;
            //      Console.WriteLine();
            //      Console.WriteLine("int[] nt = new int[4] { 98, 77, 5, 33 };");
            //      int[] nt = new int[4] { 98, 77, 5, 33 };
            //      Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            //      Console.WriteLine("nt[  0 ] 為 " + (nt[0]));
            //      Console.WriteLine("##################################################");
            //      Console.WriteLine("ArrayList fx = new ArrayList();");
            //      ArrayList fx = new ArrayList();
            //      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            //      fx.Add(24);
            //      Console.WriteLine("fx.Add(24);");
            //      Console.Write("fx[  0 ] 為 ");
            //      Console.ForegroundColor = ConsoleColor.Green;
            //      Console.WriteLine(fx[0]);
            //      Console.ForegroundColor = original;
            //      Console.WriteLine("??????????????????????????????????????????????????");
            //      fx[0] = 42;
            //      Console.WriteLine("fx[0] = 42;");
            //      Console.Write("fx[  0 ] 為 ");
            //      Console.ForegroundColor = ConsoleColor.Red;
            //// fix #1 下一行會印出什麼?
            //      Console.WriteLine(fx[0]);
            //      Console.ForegroundColor = original;
            //      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            //      Console.WriteLine();
            //      Console.ForegroundColor = ConsoleColor.Yellow;
            //      Console.WriteLine("結束");
            //      Console.ForegroundColor = original;
            //      Console.WriteLine();
            //      Console.WriteLine();
            //      Console.WriteLine();
            //      Console.WriteLine();


            ArrayList myList = new ArrayList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(false);
            myList.Add("999");
            myList.Add('2');
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
            Console.WriteLine(myList[2]);
            Console.WriteLine(myList[3]);
            Console.WriteLine(myList[4]);

        }
  }
}
