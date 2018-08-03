using System;
using System.Collections.Generic;
using System.Collections;

namespace m6_print_學員平均分數_array_ArrayList_List {
  class Program {
    static void Main(string[] args) {
// 試試存10個學生的成績,分別為
//  70,85,90,75,60,80,65,60,75,90
//  印出平均分數
//  , 但必須滿足如下兩條件來做此練習:
// A. 存10個學生的成績到
//        陣列
//       , System.Collections.ArrayList
//       , System.Collections.Generic.List
// 三種可存元素的物件內.
//  (也就是把每個學生的成績當作一個元素)
//  , 提示: System.Collections.ArrayList
//  , System.Collections.Generic.List兩種物件
// 所存元素的個數可由Count來查詢
// B. 經由找到上述三種物件內所存的每一個元素所代表的成績
//  , 算出平均分數. 印出此平均分數

      {
// 第1種做法:  用陣列
          int[] 學生成績;
        學生成績    = new int[10]{ 70, 85, 90, 75, 60, 80, 65, 60, 75, 90 };
// fix #1
        //算出平均分數. 印出此平均分數

      }

      {
        // 第2種做法:  用System.Collections.ArrayList
        System.Collections.ArrayList 學生成績
            = null;
        學生成績 = new System.Collections.ArrayList();
// fix #2  如何將十個學員的成績如右, 加到"學生成績"內當作其元素   70,85,90,75,60,80,65,60,75,90

// fix #3
        // 算出平均分數. 印出此平均分數

      }

      {
        // 第3種做法:  用System.Collections.Generic.List<int>
        System.Collections.Generic.List<int> 學生成績
            = null;
        學生成績 = new System.Collections.Generic.List<int>();
// fix #4  如何將十個學員的成績如右, 加到"學生成績"內當作其元素   70,85,90,75,60,80,65,60,75,90

// fix #5
        // 算出平均分數. 印出此平均分數

      }
    }
  }
} 
