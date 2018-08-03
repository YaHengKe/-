using System;

namespace m3_lab_print_odd_or_even
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine();
      Random rn = new Random();
      int x;
      // d 為 0.0 和 1.0(不包含1.0) 之間的亂數
      double d = rn.NextDouble();
      Console.WriteLine();
//  fix #1 觀察下一行
      Console.WriteLine("d 為 " + d);
      Console.WriteLine();
      Console.Write(" x 的值 是 ");
//  fix #2 如何讓使得 x存有 6 或 7 的值
//  請寫在下面


      Console.WriteLine(x);
      Console.WriteLine("##########################");
//  fix #3 如何讓使得 x存有 6 的值時,印出 x為偶數
//                 而 x存有 7 的值時,印出 x為奇數
//  請寫在下面

      Console.WriteLine("??????????????????????????");
      Console.WriteLine();
      Console.WriteLine("結束");
      Console.WriteLine(); 
      Console.WriteLine();

    }
  }
}
