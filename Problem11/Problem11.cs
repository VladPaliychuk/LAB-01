using System;

    internal class Problem11
    {
        static void Main()
        {

        int number = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int nDigit;

        //перевірка довжини числа
        int l=0;
        int n2 = number;
        while(n2 > 0)
        {
            l++;
            n2 /= 10;
        }
        
        if(n>l)
        {
            Console.WriteLine("-");
        }
        else
        {
            nDigit= (number / (int)Math.Pow(10, n - 1)) % 10;
            Console.WriteLine(nDigit);
        }
        
        }
    }
