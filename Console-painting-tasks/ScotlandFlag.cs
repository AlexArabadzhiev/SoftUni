using System;
class ScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n == 1)
        {
            Console.WriteLine("AB");
        }
        else
        {
            char a = 'A';
            int diesNumber = 1;
            for (int i = 1; i <= n; i++)
            {

                if (i == 1)
                {
                    string inside = new string('#', n - 2);
                    Console.Write(a);
                    Console.Write(inside);
                    Console.Write(++a);
                    if (a == 'Z')
                    {

                        a = 'A';

                    }
                    Console.WriteLine();
                }
                if (i > 1 && i <= n / 2)
                {
                    if (a == 'Z')
                    {

                        a = 'A';

                    }
                    string wave = new string('~', i - 1);
                    string inside = new string('#', n - 2 * i);
                    Console.Write(wave + ++a);
                    if (a == 'Z')
                    {

                        a = '@';

                    }
                    Console.Write(inside + ++a + wave);
                    if (a == 'Z')
                    {

                        a = '@';

                    }
                    Console.WriteLine();
                }
                if (i == (n / 2) + 1)
                {

                    string tire = new string('-', (n - 1) / 2);
                    Console.Write(tire);
                    Console.Write(++a + tire);
                    if (a == 'Z')
                    {

                        a = '@';

                    }
                    Console.WriteLine();
                }
                if (i > n / 2 && i < n)
                {

                    string wave = new string('~', n - (i + 1));
                    string inside = new string('#', diesNumber);
                    Console.Write(wave);
                    Console.Write(++a + inside);
                    if (a == 'Z')
                    {

                        a = '@';

                    }
                    Console.Write(++a + wave);
                    if (a == 'Z')
                    {

                        a = '@';

                    }
                    Console.WriteLine();
                    diesNumber = diesNumber + 2;
                }

            }
        }

    }

}

