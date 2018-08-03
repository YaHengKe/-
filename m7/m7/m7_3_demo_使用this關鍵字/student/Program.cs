using System;
class BankAccount {
  public string GetName() {
//fix #4  練習四 4 將下一行註解取消,看會發生什麼事?
    // string name = "KTM";
//fix #5 修改下一行, 來改善 練習四 所造成的問題
    return  name ;
  }
  private string name = "知名不具"; // 此帳戶的戶名
  public void SetName( string name ) //fix #3-1 將此行的 name 改成 N 
  {
//fix #2 將下一 的 this. 註解 (可寫成  /* this. */  ),看會發生什麼事?
// this可用來解決名稱衝突的問題( this 可代表執行此物件方法的物件參考)
    this.name = name; //fix #3-2 也將此行=右邊的 name 改成 N ,看會發生什麼事?
  }
}
class Program {
  static void Main(string[] args) {
    ConsoleColor ori = Console.ForegroundColor;
    Console.WriteLine();
    BankAccount yours = new BankAccount();
    Console.WriteLine("##############################");
    Console.Write("yours.GetName() 為 ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(yours.GetName());
    Console.ForegroundColor = ori;
    Console.WriteLine("??????????????????????????????");
    yours.SetName("張德標");
    Console.Write("yours.GetName() 為 ");
    Console.ForegroundColor = ConsoleColor.Red;
// fix #1 觀察下一行會印出什麼?
    Console.WriteLine(yours.GetName());
    Console.ForegroundColor = ori;
    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
    Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
  }
}