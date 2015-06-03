using System;
class eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i == 1 || i == n)
            {
                       
                string asteriks = new string('*', (2 * n) - 2);
                string bridge = new string(' ', n-1);
                Console.WriteLine(' ' + asteriks + ' ' + bridge + ' ' + asteriks + ' ');

            }
            if (i > 1 && i < n - 1)
            {            
           
                string lences = new string('/', (2 * n) - 2);
                string bridge = new string(' ', n - 1);
                string brid = new string(' ', n - 1);
                Console.WriteLine('*' + lences + '*' + bridge + '*' + lences + '*');
            }
            if (i == n / 2)
            {
                string lences = new string('/', (2 * n) - 2);
                string bridge = new string('-', n - 1);
                string brid = new string(' ', n - 1);
                Console.WriteLine('*' + lences + '*' + bridge + '*' + lences + '*');
            }
        }

    }
}