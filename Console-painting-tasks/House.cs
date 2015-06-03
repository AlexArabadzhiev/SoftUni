using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dot = 1;
        Console.WriteLine("{0}*{0}", new string('.', n/2));
        for (int i = 1; i < n/2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n/2 - i), new string('.', dot));
            dot += 2;
        }
        Console.WriteLine(new string('*', n));
        for (int i = n/2 +1; i <n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n/4), new string('.', n - (2* (n/4)) - 2) );
        }
        Console.WriteLine("{0}{1}{0}", new string('.', n/4), new string('*', n - 2*(n/4)));
    }
}
