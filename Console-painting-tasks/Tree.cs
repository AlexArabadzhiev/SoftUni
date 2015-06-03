using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tree
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                int asterisksCount = i;
                string asterisks = new string('*', asterisksCount);
                int spacesCount = n - asterisksCount;
                string spaces = new string(' ', spacesCount);
                Console.Write(spaces);
                Console.Write(asterisks);
                Console.Write(" | ");
                Console.Write(asterisks);
                Console.WriteLine(spaces);

            }
        }
    }
}
