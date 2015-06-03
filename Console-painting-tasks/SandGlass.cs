using System;
    class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1 ; i <= n; i++)
        {
            if (i == 1 || i == n)
	        {
		        string asteriks = new string('*', n);
                Console.WriteLine(asteriks);
	        }
            if (i > 1 && i <= n/2 + 1)
	        {
                string dots = new string('.', i - 1);
                string asteriks = new string('*', n - 2*(i-1));
                Console.WriteLine(dots + asteriks + dots);
	        }
            if (i > n/2 + 1 && i < n)
            {
                string dots = new string('.', n - i);
                string asteriks = new string('*', n - 2 * (n - i));
                Console.WriteLine(dots + asteriks + dots);
            }
        }
    }
}

