using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    class star
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int g = 1;
            int t = 2;
            int m = 1;
            Console.WriteLine("{0}*{0}", new string('.',n));
            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', n - i), new string('.', g));
                g += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n/2 +1), new string('.', g));
            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', i), new string ('.', (2*n-1)-t));
                t += 2;
            }
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', n/2), new string('.', n/2 -1));
            for (int i = 1; i <= n/2 -1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', n/2 - i), new string('.', n/2-1), new string('.', m));
                m += 2;                
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n/2 +1), new string('.', n-1));
        }
    }
}
