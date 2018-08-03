using System;


class Program
{
    static void Main(string[] args)
    {
        ConsoleColor origin = System.Console.ForegroundColor;
        Console.WriteLine();
        long[] row = new long[4] { 3, 71, 2, 5 };
        Console.WriteLine();
        Console.WriteLine(); Console.WriteLine();
        long[] copy = row;
        Console.WriteLine("long[] copy = row;");
        Console.WriteLine("####################################################");
        Console.Write("row[0] 為 ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(row[0]);
        Console.ForegroundColor = origin;
        Console.WriteLine("????????????????????????????????????????????????????");
        Console.ForegroundColor = ConsoleColor.Yellow;
        //fix #2 將下兩行註解取消, 會如何?
        Console.WriteLine("copy[0] = copy[0] + 1;");
        copy[0] = copy[0] + 1;
        Console.ForegroundColor = origin;
        Console.Write("row[0] 為 ");
        Console.ForegroundColor = ConsoleColor.Red;
        //fix #1 觀察下一行會印出什麼?
        Console.WriteLine(row[0]);
        Console.ForegroundColor = origin;
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();





        //int[] arr = new int[] { 5, 9, 8, 3, 1, 6, 7 };


        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write(arr[i] + " ");
        //}

        //Console.WriteLine("");
        //Console.WriteLine("=============分隔線=============");
        //int Num_Sort = 0;
        //for (int i = 0; i < arr.Length - 2; i++)
        //{
        //    for (int j = 0; j < arr.Length - 1; j++)
        //    {
        //        if (arr[j] < arr[j + 1])
        //        {
        //            int k = arr[j];
        //            arr[j] = arr[j + 1];
        //            arr[j + 1] = k;
        //        }
        //    }

        //    for (int l = 0; l < arr.Length; l++)
        //    {
        //        Console.Write(arr[l] + " ");
        //    }
        //    Num_Sort += 1;
        //    Console.WriteLine("       第{0}次排序的結果", Num_Sort);
        //}



        //for (int i = 0; i < arr.Length; i++)
        //{
        //    Console.Write(arr[i]);
        //}


    }
}

