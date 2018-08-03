using System;
class BankAccount {
  public void Deposit(double amount) {
    if (balance + amount >= 0) {
      balance = balance + amount;
    }
    else {
      Console.WriteLine("存款失敗");
    }
  }
  public void Withdraw(double amount) {
// fix #14 觀察下面的 if else
    if (balance - amount >= 0) {
      balance = balance - amount; 
    } 
    else {
      ConsoleColor original = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine("提款失敗");
      Console.ForegroundColor = original;
    } 
  }
//fix #10 將下一行的 public 改成 private 看會如何?
  public double balance;
  private string name; 
  public double GetBalance() {
    return balance;
  }
}
class Program {
  static void Main(string[] args) {
    ConsoleColor original = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("存款餘額不得為負數");
    Console.ForegroundColor = original;
    Console.WriteLine();
// fix #1  觀察下面的 yours 變數
//         ,  yours 變數 為  Reference型態
//         ,  yours 變數 用來存放物件的參考
//         null 代表無效的參考
// fix #16 將下一行 = null 刪掉, 會如何?
    BankAccount yours = null ;
// fix #15 將下一行註解 看會如何?
// fix #2  觀察下一行的 new BankAccount( )
    yours = /* 建立物件 */ new BankAccount( ) ;
    // new BankAccount() 為產生物件的語法 
    // 此語法 也同時算出物件的參考
    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
    Console.Write("剛開始為 ");
    Console.ForegroundColor = ConsoleColor.Red;
// fix #3  執行此程式會如何? 
// fix #4  修改下一行的 BankAccount 成為 yours 會如何?
// fix #5 觀察下一行會印出什麼?
    Console.Write(yours.GetBalance( ) );
    Console.ForegroundColor = original;
    Console.WriteLine(" 元");
    Console.WriteLine("################################");
// fix #6 觀察下一行
    yours.Deposit(100);
    Console.WriteLine("yours.Deposit(100);");
    Console.Write("後來為 ");
    Console.ForegroundColor = ConsoleColor.Green;
// fix #7 觀察下一行會印出什麼?
    Console.Write( yours.GetBalance() );
    Console.ForegroundColor = original;
    Console.WriteLine(" 元");
// fix #9  將下一行註解取消, 再觀察練習三會印出什麼?
// fix #11  將下一行恢復成註解 
    // yours.balance = yours.balance - 170;
    Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
// fix #12  將下一行註解取消, 再觀察練習八 會印出什麼?
// fix #13  將下一行的 70 改成 170 再觀察練習八 會印出什麼?
    //yours.Withdraw(170);
    Console.WriteLine("????????????????????????????????");
    Console.Write("最後為 ");
    Console.ForegroundColor = ConsoleColor.Yellow;
// fix 練習八 #8 觀察下一行會印出什麼?
    Console.Write(yours.GetBalance());
    Console.ForegroundColor = original;
    Console.WriteLine(" 元");
    Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
    Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
    Console.WriteLine(); Console.WriteLine();
  }
}