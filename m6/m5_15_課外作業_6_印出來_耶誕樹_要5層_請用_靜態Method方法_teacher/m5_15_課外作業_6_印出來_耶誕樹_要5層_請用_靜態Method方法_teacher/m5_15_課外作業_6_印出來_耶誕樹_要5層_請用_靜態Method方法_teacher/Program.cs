using System;

class Program
{
    static void Main(string[] args)
    {
        int 幾曾 = 5;
        int 幾個葉子;
        int 幾個空白;

        幾個空白 = 幾曾 - 1;
        幾個葉子 = 1;


        for (int i = 1; i <= 5; i++)
        {
            Program.drawHowManyWhatChar(幾個空白, ' '); // 可印出9個*
            drawHowManyWhatChar( 幾個葉子, '*'); // 可印出9個*
            Program.drawHowManyWhatChar(1, '\n');

            幾個空白 -= 1;
            幾個葉子 += 2;
        }
       
    }

    public static void drawHowManyWhatChar(int howMany, char whatChar)
    {
        // fix #1 請在下面寫程式, 可印出 howMany 個 whatChar 字
        for (int i = 1; i <= howMany; i++)
        {
            Console.Write(whatChar);
        }
    }
}

