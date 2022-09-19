using System;

internal class Problem14
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int max = 0;

        if(max<a)
        {
            max = a;
        }
        if (max < b)
        {
            max = b;
        }
        if (max < c) { max = c; }

        Console.WriteLine(max);
    }
}

