using System;


namespace mod6_Generic方法 {
  class Adt {
    static public ItemType GenericFunction<ItemType>(ItemType item) {
      return item;
    }
  }
  class Program {
    static void Main(string[] args) {
      Console.WriteLine();
      bool RV;
// fix #1 觀察下一行泛型方法的使用方式
      RV = Adt.GenericFunction<bool>(false);
      Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
// fix #2 執行此程式, 觀察下一行會印出什麼? 
      Console.WriteLine(!RV);
      Console.WriteLine("###########################################");
      int x;
// fix #3 觀察下一行泛型方法的使用方式
      RV = Adt.GenericFunction(true);
      Console.WriteLine(!RV);
      Console.WriteLine("???????????????????????????????????????????");
// fix #4 將下一行註解取消, 看會如何? 觀察後恢復成註解
      // x = Adt.GenericFunction(true);
// fix #5 觀察下一行泛型方法的使用方式
      x = Adt.GenericFunction(2);
      Console.WriteLine(x + 3);
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

      Console.WriteLine();
      Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
      Console.WriteLine();
    }
  }


}
