using System;

class Program {
  static void Main(string[] args) {
    ConsoleColor original = Console.ForegroundColor;
    Console.WriteLine();
    {
      string a = new string(new char[] { 't', 'e', 's', 't' });
      string b = new string(new char[] { 't', 'e', 's', 't' });
      Console.WriteLine("a為" + a);
      Console.WriteLine("b為" + b);
      Console.WriteLine("if (a == b) ");
      Console.WriteLine();
//fix #1 觀察下面if會印出什麼?     
      Console.ForegroundColor = ConsoleColor.Cyan;
      if (a == b)  //比較的結果相等 
      {
        Console.WriteLine("a   和    b  所參考到的字串內容相等");
      }
      else
      {
        Console.WriteLine("a   和    b  所參考到的字串內容不同");
      }
      Console.ForegroundColor = original;
      Console.WriteLine("########################################");
    }
    Console.WriteLine();
    {
      string a = new string(new char[] { 't', 'e', 's', 't' });
      string b = new string(new char[] { 't', 'e', 's', 't' });
      Console.WriteLine("a為" + a);
      Console.WriteLine("b為" + b);
      Console.WriteLine("if ( a.Equals( b ) ) ");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Green;
//fix #2 觀察下面if會印出什麼?
      if (a.Equals(b))  //比較的結果相等 
      {
        Console.WriteLine("a   和    b  所參考到的字串內容相等");
      }
      else
      {
        Console.WriteLine("a   和    b  所參考到的字串內容不同");
      }
      Console.ForegroundColor = original;
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
    }
    Console.WriteLine();
    {
      string a = new string(new char[] { 't', 'e', 's', 't' });
      string b = new string(new char[] { 't', 'e', 's', 't' });
      Console.WriteLine("a為" + a);
      Console.WriteLine("b為" + b);
      Console.WriteLine("string.ReferenceEquals(a , b) 為 ");
      Console.WriteLine();
      Console.ForegroundColor = ConsoleColor.Yellow;
//fix #4  將下一行註解取消, 再觀察下面if會印出什麼?
      // b = a;
//fix #3 觀察下面if會印出什麼?
      if (string.ReferenceEquals(a, b))  //比較 變數內容
      {
        Console.WriteLine("a   和    b  變數內容相等");
      }
      else
      {
        Console.WriteLine("a   和    b  變數內容不同");
      }

      Console.ForegroundColor = original;
      Console.WriteLine("????????????????????????????????????????");
      Console.WriteLine();
      Console.WriteLine();
    }
  }
}