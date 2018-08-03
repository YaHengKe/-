using System;

namespace module6_System_Array常用類別的方法 {
  class Program {
    static void Main(string[] args) {
      int[] us = { 47, 25, 89 , 47 };
// fix #1 觀察會如何?
      for (int i = 0; i < us.Length; i += 1)
      {
        Console.WriteLine("us[" + i + "] 為 \t" + us[i]);
      }
      Console.WriteLine("在  System.Array.Sort(us, new MyComparaer())                   之後");
      System.Array.Sort(us);
// fix #2 觀察會如何?
      for (int i = 0; i < us.Length; i += 1)
      {
        Console.WriteLine("us[" + i + "] 為 \t" + us[i]);
      }
      Console.WriteLine("###################################################");
      int[] cd = new int[us.Length];
      Console.WriteLine("在  System.Array.Copy(us, cd, us.Length)    之後");
      System.Array.Copy(us, cd, us.Length);
// fix #3 觀察會如何?
      for (int i = 0; i < cd.Length; i += 1)
      {
        Console.WriteLine("cd[" + i + "] 為 \t" + cd[i]);
      }
      int fd = 0;
      Console.WriteLine("在    fd = System.Array.IndexOf(cd, 47)     之後");
      fd = System.Array.IndexOf(cd, 47);
// fix #4 觀察會如何?
      Console.WriteLine("fd 為 \t" + fd);
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.WriteLine("在    fd = System.Array.LastIndexOf(cd, 47) 之後  ");
      fd = System.Array.LastIndexOf(cd, 47);
// fix #5 觀察會如何?
      Console.WriteLine("fd 為 \t" + fd);
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
      Console.WriteLine("在    System.Array.Clear(cd, 0, cd.Length)  之後");
      System.Array.Clear(cd, 0, cd.Length);
// fix #6 觀察會如何?
      for (int i = 0; i < cd.Length; i += 1)
      {
        Console.WriteLine("cd[" + i + "] 為 \t" + cd[i]);
      }
      Console.WriteLine();
    }
  }
}
