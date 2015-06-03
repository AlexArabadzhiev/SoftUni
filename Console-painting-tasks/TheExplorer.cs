using System;
    class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int h = 1;
        int m = n - 4;
        int g = 1;
                Console.WriteLine("{0}*{0}", new string('-', n/2));
            
            for (int i = 1; i < n/2; i++)
			
            {
                
                Console.WriteLine("{0}*{1}*{0}", new string ('-', n/2 - i), new string ('-', h));
                h += 2;
            }
            Console.WriteLine("*{0}*", new string('-', n - 2));
            for (int i = n/2 + 1 ; i < n -1 ; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('-', g), new string ('-', m));
                m = m - 2;
                g++;
            }
            Console.WriteLine("{0}*{0}", new string('-', n / 2));
        }

    }


