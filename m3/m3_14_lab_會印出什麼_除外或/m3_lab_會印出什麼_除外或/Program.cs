using System;

class Program
{
    static void Main(string[] args)
    {
        bool 結果, A, B;
        Console.WriteLine("除外或");
        Console.WriteLine("????????????????????????????");
        A = true;
        B = true;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A ^ B;
        Console.Write("結果 = A ^ B; 結果 為 ");
        // fix #1 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = false;
        B = true;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A ^ B;
        Console.Write("結果 = A ^ B; 結果 為 ");
        // fix #2 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = true;
        B = false;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A ^ B;
        Console.Write("結果 = A ^ B; 結果 為 ");
        // fix #3 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = false;
        B = false;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A ^ B;
        Console.Write("結果 = A ^ B; 結果 為 ");
        // fix #4 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine("############################");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}

