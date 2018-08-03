using System;
class Program {
    static void Main(string[] args) {
        bool 結果, A, B;
        Console.WriteLine();
        Console.WriteLine("而且");
        A = true;
        B = true;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A && B;
        Console.Write("結果 = A && B; 結果 為 ");
        // fix #1 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = false;
        B = true;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A && B;
        Console.Write("結果 = A && B; 結果 為 ");
        // fix #2 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = true;
        B = false;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A && B;
        Console.Write("結果 = A && B; 結果 為 ");
        // fix #3 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = false;
        B = false;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A && B;
        Console.Write("結果 = A && B; 結果 為 ");
        // fix #4 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        Console.WriteLine("或者");
        A = true;
        B = true;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A || B;
        Console.Write("結果 = A || B; 結果 為 ");
        // fix #5 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = false;
        B = true;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A || B;
        Console.Write("結果 = A || B; 結果 為 ");
        // fix #6 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = true;
        B = false;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A || B;
        Console.Write("結果 = A || B; 結果 為 ");
        // fix #7 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        A = false;
        B = false;
        Console.Write("A 為 ");
        Console.Write(A);
        Console.Write(" , B 為 ");
        Console.WriteLine(B);
        結果 = A || B;
        Console.Write("結果 = A || B; 結果 為 ");
        // fix #8 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        Console.WriteLine("反");
        //!是一元運算子, 例如
        bool isOdd = false;
        Console.Write("isOdd 為 ");
        Console.WriteLine(isOdd);
        結果 = !isOdd;
        Console.Write("結果 = !isOdd; 結果 為 ");
        // fix #9 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        isOdd = true;
        Console.Write("isOdd 為 ");
        Console.WriteLine(isOdd);
        結果 = !isOdd;
        Console.Write("結果 = !isOdd; 結果 為 ");
        // fix #10 請回答下行會印出什麼?
        Console.WriteLine(結果);
        Console.WriteLine();
        Console.WriteLine();
    }
}

