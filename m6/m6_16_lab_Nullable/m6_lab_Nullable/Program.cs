using System;


namespace m6_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("開始");
// fix #1 觀察下面程式的執行
            Nullable<int> x = new Nullable<int>(125); //也可寫成  int? x  =  125 ;
            // int? x  =  125 ;
            x = null; // 設成 null 代表 x 沒有填一個 int 的值
            if (x.HasValue)
            { /*  x.HasValue 為 true  代表 x 有填值 */
                Console.WriteLine(x.Value);/* 若 x 有填值, 可用 x.Value 查看所填的 int 的值  */
            }
            if (x != null)
            { /*    代表x有填值 */
                Console.WriteLine(x.Value);
            }
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            x = 125;// x = 125 代表 x 有填 125 的值
            if (x.HasValue)
            { /*  x.HasValue 為 true  代表 x 有填值 */
                Console.WriteLine(x.Value);/* 若 x 有填值, 可用 x.Value 查看所填的 int 的值  */
            }
            if (x != null)
            { /*    代表x有填值 */
                Console.WriteLine(x.Value);
            }
            Console.WriteLine("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
            //            T? 即 System.Nullable<T>
            //例如:  Nullable<int> a; //也可寫成  int? a ;
            int? a = null; // 指派 null 來代表 a 未填值
            Console.WriteLine();
            if (!(a.HasValue))
            {  /*    代表 a 未填值 */
                //  Console.WriteLine(a.Value); // 此時不可取值
                Console.WriteLine("代表 a 未填值");
            }
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine();
            if (a == null) { /* 代表 a 未填值 */
                Console.WriteLine("代表 a 未填值");
            }
            Console.WriteLine("#############################");
            Console.WriteLine("結束");
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



           
        }
    }
}
