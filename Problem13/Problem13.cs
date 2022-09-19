using System;

internal class Problem13
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        bool result;

        if(n%9==0 || n%11==0 || n % 13 == 0)
        {
            result = true;
        }
        else
        {
            result = false;
        }

        Console.WriteLine(result);
    }
}

