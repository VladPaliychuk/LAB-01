using System;

    internal class Problem8
    {
        static void Main()
        {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        double average, sum;
        sum = a + b + c;
        average = sum / 3;

        Console.WriteLine(average);
        }
    }
