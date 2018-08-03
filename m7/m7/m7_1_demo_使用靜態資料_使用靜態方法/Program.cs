using System;
class BankAccount
{
  public void Deposit(double amount) {
    // 略
  }
  public void Withdraw(double amount) {
    // 略
  }
  private double balance; 
  private string name;
  public double GetBalance() {
    return balance;
  }
// fix #1 觀察下一行
// fix #5 將下一行的 public 改成 private 看會如何?
  public static double Interest_rate = 0.07;
  public static double Fetch_interest_rate( )
  {
    return BankAccount.Interest_rate;
  }
} // end of class, BankAccount
class Program {
  static void Main(string[] args) {
    ConsoleColor original = Console.ForegroundColor;
    Console.WriteLine();
    Console.WriteLine("##########################################");
    Console.Write("原本 BankAccount.Interest_rate 為 ");
    Console.ForegroundColor = ConsoleColor.Green;
// fix #7  將下一行BankAccount.Interest_rate 改成 
//          BankAccount.Fetch_interest_rate() 再觀察會印出什麼?
// fix #2 觀察下一行會印出什麼?
    Console.Write( BankAccount.Interest_rate );
    Console.ForegroundColor = original;
    Console.WriteLine();
// fix #6  將下一行恢復成註解 
// fix #4  將下一行註解取消, 看會如何? 
    //BankAccount.Interest_rate = 0.8;
    Console.WriteLine("??????????????????????????????????????????");
    Console.Write("後來 BankAccount.Interest_rate 為 ");
    Console.ForegroundColor = ConsoleColor.Yellow;
// fix #8  將下一行BankAccount.Interest_rate 改成 
//          BankAccount.Fetch_interest_rate() 再觀察會印出什麼?
// fix  #3 觀察下一行會印出什麼?
    Console.Write(BankAccount.Interest_rate );
    Console.ForegroundColor = original;
    Console.WriteLine();
    Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
    Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
    Console.WriteLine(); Console.WriteLine();
  }
}