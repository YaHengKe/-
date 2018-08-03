using System;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("測驗 #1");

            Console.WriteLine();
// fix 測驗 #1  先取消下面for敘述的註解, 再觀察語法有錯嗎? 
//               (是有錯, 如何修正?)

            for (int i = 0 /*,*/; i < 10 /*,*/; i++)//for (int i = 0, i < 10 , i++)
                Console.Write(i + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        {
            Console.WriteLine("測驗 #2");
            Console.WriteLine();
            int i = 0;
// fix 測驗 #2  先取消下面while敘述的註解, 再執行, 觀察下面while有錯嗎? 
//     (有錯 , 但不是語法錯誤, 是會形成無窮迴圈 , 如何修正? )            

            while (i < 10)
            {   Console.Write(i + " ");// Console.Write(i + " ");
                i += 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine();


        {
            Console.WriteLine("測驗 #3");
            Console.WriteLine();
// fix 測驗 #3  先執行, 觀察下面for有錯嗎??
//  (有錯 , 但不是語法錯誤, 是會形成一次都不重複的迴圈 )            
//  , 如何修正如下:
//   將i >= 10改成i < 10 
            for (int i = 0; /*i >= 10*/ i < 10  ; i++)//for (int i = 0; i >= 10; i++)
                Console.Write(i + " ");
        }

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        {
            int i;
            i = 0;
            Console.WriteLine("測驗 #4");
            Console.WriteLine();
// fix 測驗 #4  先取消下面do敘述的註解, 再執行, 觀察下面do有錯嗎? 
//   (有錯 , 是語法錯誤, 因do和while所構成的迴圈之間只能有一個敘述 ) 
// 
//      修正如下: 
//      將
//        Console.Write(i);
//        i++;
//      改成用 { } 包起來, 型成 一個敘述 
            do
            { Console.Write(i + " ");
                i++; }
            while (i < 10);


            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("結束測驗");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();

    }
}


