﻿using System;

internal class Problem12
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        bool result;

        if(n>20 && n%2!=0)
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

