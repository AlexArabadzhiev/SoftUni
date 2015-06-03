using System;
    class HouseWindow
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int g = 1;
            Console.WriteLine("{0}*{0}", new string('.', n - 1));
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n-i), new string('.', g));
                g += 2;
            }
            Console.WriteLine("{0}", new string('*', 2*n - 1));
            for (int i = 1; i <= n/4; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 2* n -3));
            }
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("*{0}{1}{0}*", new string('.', n/2 ), new string('*', n-3));
            }
            for (int i = 1; i <= n / 4; i++)
            {
                Console.WriteLine("*{0}*", new string('.', 2 * n - 3));
            }
            Console.WriteLine("{0}", new string('*', 2 * n - 1));
        }
    }
