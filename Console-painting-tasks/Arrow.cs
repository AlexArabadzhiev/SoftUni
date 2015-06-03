using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int g = n + 2 * (n / 2) - 4;
            Console.WriteLine("{0}{1}{0}", new string('.', n/2), new string('#', n));
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', n/2), new string('.', n-2));
            }
            Console.WriteLine("{0}#{1}#{0}", new string('#', n / 2), new string('.', n - 2));
            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', i), new string('.', g));
                g -= 2;
            }
            Console.WriteLine("{0}#{0}", new string('.', n-1));
        }
    }
}
