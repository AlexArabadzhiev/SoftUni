using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Plane
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}*{0}", new string('.', (3*n-1)/2));
        int firstDot = 1;
        int SecondDot = n-4;
        for (int i = 0; i < n/2+2; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (3*n-2-firstDot)/2), new string('.', firstDot));
            firstDot += 2;
        }
        firstDot += 2;
        for (int i = 0; i < n/2 -1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', (3 * n - 2 - firstDot) / 2), new string('.', firstDot));
            firstDot += 4;
        }
        firstDot=1;
        Console.WriteLine("*{0}*{1}*{0}*", new string('.', n-2), new string('.',3*n -4 -2*(n-2)));
        for (int i = 1; i <= n/2-1; i++)
        {
            Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*", new string('.', SecondDot), new string('.', firstDot), new string('.', 3 * n - 4 - 2 * (n - 2)));
            SecondDot -= 2;
            firstDot += 2;
        }
        int J = n;
        for (int i = 1; i <= n-1; i++)
        {
            Console.WriteLine("{0}*{1}*{0}", new string('.', n-i), new string('.', J));
            J += 2;
        }
        Console.WriteLine("{0}", new string('*', n*3));
    }
}
