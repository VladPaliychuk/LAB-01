using System;

internal class Problem15
{
    static void Main()
    {
        double a=double.Parse(Console.ReadLine());
        double b=double.Parse(Console.ReadLine());
        double c=double.Parse(Console.ReadLine());
        string s1 = "Positive";
        string s2 = "Negative";
        int i = 0;

        if (a < 0) { i++; }
        if (b < 0) { i++; }
        if (c < 0) { i++; }

        if(i==1 || i == 3) { Console.WriteLine(s2); }
        if(i==0 || i == 2) { Console.WriteLine(s1); }
    }
}

