using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineGlass
{
    class WineGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int g = 2;
            Console.WriteLine("\\{0}/", new string('*', n-2));
            for (int i = 1; i < n/2; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('.', i), new string ('*', n-2-g));
                g += 2;
            }
            if (n>=12)
            {
                for (int i = n/2 +1; i <= n - 2; i++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', (n/2)-1));
                    
                }
                Console.WriteLine("{0}", new string('-', n));
                Console.WriteLine("{0}", new string('-', n));
            }
            if (n < 12)
            {
                for (int i = n / 2 + 1; i <= n - 1; i++)
                {
                    Console.WriteLine("{0}||{0}", new string('.', (n / 2) - 1));

                }
                Console.WriteLine("{0}", new string('-', n));
                
            }
        }
    }
}
