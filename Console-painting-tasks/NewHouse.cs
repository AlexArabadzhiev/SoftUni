using System;
    class NewHouse
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}{1}*{1}{0}", new string('-', n/2 -i +1), new string('*', i -1));
            }
            Console.WriteLine("{0}", new string('*', n));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|{0}|", new string('*', n-2));
            }
        }
    }