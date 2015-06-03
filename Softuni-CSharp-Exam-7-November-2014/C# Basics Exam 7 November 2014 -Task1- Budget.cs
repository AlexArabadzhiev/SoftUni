using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Budget
{
    static void Main()
    {
        int WholeMoney = int.Parse(Console.ReadLine());
        int WeekdaysOut = int.Parse(Console.ReadLine());
        int HomeWeekends = int.Parse(Console.ReadLine());
        int ExpencesNormalWeekends = ((4 - HomeWeekends) * 2) * 20;
        int ExpencesWeekdaysGoungOut = WeekdaysOut * ((WholeMoney * 3) / 100 + 10);
        int ExpencesNormalWeekDays = (22 - WeekdaysOut) * 10;
        int Leftover = WholeMoney - ExpencesNormalWeekends - ExpencesNormalWeekDays - ExpencesWeekdaysGoungOut - 150;
        if (Leftover > 0)
        {
            Console.WriteLine("Yes, leftover {0}." , Leftover);
        }
        if (Leftover == 0)
        {
            Console.WriteLine("Exact Budget.");
        }
        if (Leftover<0)
        {
            Leftover = Leftover * -1;
            Console.WriteLine("No, not enough {0}.", Leftover);
        }

    }
}
