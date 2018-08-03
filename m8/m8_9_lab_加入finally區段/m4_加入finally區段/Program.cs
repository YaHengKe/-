using System;

class Program
{
    static void Main(string[] args)
    {
        ConsoleColor original = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("開始");
        Console.ForegroundColor = original;

        System.IO.StreamWriter sw = null;
        sw = new System.IO.StreamWriter("rec.txt");
        Random P = new Random();
        try
        {
            Console.WriteLine("進到 某方法() 內的 try 裡");
 // fix #1 觀察下面的訊息 是寫到   bin/Debug/rec.txt 檔案內
            sw.WriteLine("進到 某方法() 內的 try 裡");
            double DD = P.NextDouble();
            Console.WriteLine("DD  為 " + DD);
                 sw.WriteLine("DD  為 " + DD);

            int j = (int)(DD * 3);
            Console.WriteLine("j  為 " + j);
                 sw.WriteLine("j  為 " + j);

            int k = 45 / j;
            Console.WriteLine("45/j  為 " + k);
                 sw.WriteLine("45/j  為 " + k);

// fix 練習 #4 觀察 下面 的 if  會不會有問題?
// fix #5-1 將下四行註解
            if (sw != null)
            {
                sw.Dispose();
            }
        }
        finally // fix #2 觀察 此 finally 在什麼狀況會被執行嗎?
 // 答案:  在只要程式執行進到對應的 try 內, 此 finally 就會被執行
        {
            //把不管 程式執行是否發生例外
            //都需要執行的敘述放在finally區段中
 // fix #5-2 將下四行註解取消,  再觀察 練習 #4 可能會發生的問題 可被改善?
            //if ( sw != null )
            //{
            //    sw.Dispose();
            //}
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("教室 XXX, 防線");
            Console.ForegroundColor = original;
            Console.WriteLine(); 
        }
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        // fix #3 觀察下面印出的訊息
        Console.WriteLine("結束");
        Console.ForegroundColor = original;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

