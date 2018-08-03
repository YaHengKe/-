using System;

using System.Drawing;

namespace m3_demo_struct型態
{
  class Program
  {
    static void Main(string[] args)
    {
      //使用struct型態
      Employee p;
// fix #1 觀察下兩行
      p.Name = "Joe";
      p.age = 23;
      Console.WriteLine("#############################");
      Console.Write("p.Name  為 ");
// fix #2 請回答下行會印出什麼?
      Console.WriteLine(p.Name);
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.Write("p.age  為 ");
// fix #3 請回答下行會印出什麼?
      Console.WriteLine(p.age);
      Console.WriteLine("?????????????????????????????");
      Console.WriteLine("實例");
      Console.WriteLine(" Point pnt = new Point(7, 8);");
      Point pnt =
// System.Drawing.Point 有設計建構子(module 7 會討論 建構子)
        new Point(7, 8);
      Console.WriteLine("#############################");
// fix #4 請回答下行會印出什麼?
      Console.Write("pnt.X  為 ");
      Console.WriteLine(pnt.X);
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.Write("pnt.Y  為 ");
      Console.WriteLine(pnt.Y);
      Console.WriteLine("?????????????????????????????");
      Console.WriteLine("pnt.X = 65;");
      Console.WriteLine("pnt.Y = 92;");
      pnt.X = 65;
      pnt.Y = 92;
      Console.WriteLine("#############################");
      Console.Write("pnt.X  為 ");
      Console.WriteLine(pnt.X);
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.Write("pnt.Y  為 ");
// fix #5 請回答下行會印出什麼?
      Console.WriteLine(pnt.Y);
      Console.WriteLine("?????????????????????????????");
// fix #6-1 觀察下兩行
      Employee A
       = new Employee("Mary", 79);
      Console.WriteLine("#############################");
      Console.Write("A.Name  為 ");
// fix #7 請回答下行會印出什麼?
      Console.WriteLine(A.Name);
      Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
      Console.Write("A.age  為 ");
// fix #8 請回答下行會印出什麼?
      Console.WriteLine(A.age);
      Console.WriteLine("?????????????????????????????");
      Console.WriteLine();
      Console.WriteLine();
    }
  }
  // 定義struct型態
  public struct Employee
  {
    public string Name;
    public int age;
// fix #6-2 觀察下面建構子
    public Employee(string N, int a)
    {
      Name = N;
      age = a;
    }
  }

}
