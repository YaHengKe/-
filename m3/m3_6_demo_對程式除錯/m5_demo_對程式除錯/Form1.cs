using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m5_demo_對程式除錯 {
  public partial class Form1 : Form {

    public Form1() {
      InitializeComponent();

// fix #2 若你用  F5 執行此程式, 會如何?

      System.Diagnostics.Debug.WriteLine("   ");
// fix #1 觀察下三行程式, 若你用 F5 執行此程式
// , 應該可在 "輸出" 的 "偵錯" 上看到一些訊息
// , 看完後請用 Shift + F5 停止偵錯
      System.Diagnostics.Debug.WriteLine("曹講師XXXX 教室");
      System.Diagnostics.Debug.WriteLine("曹講師msit: 在這裡");
      System.Diagnostics.Debug.WriteLine("曹講師msit: 有在'輸出'的'偵錯'上看到此行訊息嗎?");

      System.Diagnostics.Debug.WriteLine("   ");

    }
  }
}
