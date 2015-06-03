using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddEvenCounter
{
    static void Main()
    {
        int NumberSets = int.Parse(Console.ReadLine());
        int NumbersInSet = int.Parse(Console.ReadLine());
        string OddOrEven = Console.ReadLine();
        int OddCount = 0;
        int EvenCount = 0;        
        int SetPrintODD = 1;
        int SetPrintEVEN = 1;
        string PrintOdd = "";
        string PrintEven = "";
        for (int k = 0; k < NumbersInSet; k++)
        {
        int CurrentNum = int.Parse(Console.ReadLine());
        if (CurrentNum == 0)
        {
            
            continue;
        }
        else if (CurrentNum %2 ==0)
	        {
                EvenCount += 1;
	        }
        else if (CurrentNum % 2 != 0)
            {
                OddCount += 1;
            }
        }        
        for (int i = 1; i <= NumberSets-1; i++)
        {
            int EvenCount2 = 0;
            int  OddCount2 = 0;
            for (int k = 0; k < NumbersInSet; k++)
            {
                int CurrentNum = int.Parse(Console.ReadLine());
                if (CurrentNum == 0)
                {
                    
                    continue;
                }
                 else if (CurrentNum % 2 == 0)
                {
                    EvenCount2 += 1;
                }
                 else if (CurrentNum % 2 != 0)
                {
                    OddCount2 += 1;
                }
            }
            if (EvenCount2 > EvenCount)
            {
                EvenCount = EvenCount2;
                SetPrintEVEN += 1;
            }
            if (OddCount2> OddCount)
            {
                OddCount = OddCount2;
                SetPrintODD += 1;
            }
        }
        if (OddOrEven == "odd" && OddCount == 0)
        {
            Console.WriteLine("No");
            return;
        }
        if (OddOrEven == "even" && EvenCount == 0)
        {
            Console.WriteLine("No");
            return;
        }
        if (SetPrintODD == 1)
        {
            PrintOdd = "First";
        }
        else if (SetPrintODD == 2)
        {
            PrintOdd = "Second";
        } 
        else if (SetPrintODD == 3)
        {
            PrintOdd = "Third";
        }
        else if (SetPrintODD == 4)
        {
            PrintOdd = "Fourth";
        }
        else if (SetPrintODD == 5)
        {
            PrintOdd = "Fifth";
        }
        else if (SetPrintODD == 6)
        {
            PrintOdd = "Sixth";
        }
        else if (SetPrintODD == 7)
        {
            PrintOdd = "Seventh";
        }
        else if (SetPrintODD == 8)
        {
            PrintOdd = "Eighth";
        }
        else if (SetPrintODD == 9)
        {
            PrintOdd = "Ninth";
        }
        else if (SetPrintODD == 10)
        {
            PrintOdd = "Tenth";
        }
        if (SetPrintEVEN == 1)
        {
            PrintEven = "First";
        }
        else if (SetPrintEVEN == 2)
        {
            PrintEven = "Second";
        }
        else if (SetPrintEVEN == 3)
        {
            PrintEven = "Third";
        }
        else if (SetPrintEVEN == 4)
        {
            PrintEven = "Fourth";
        }
        else if (SetPrintEVEN == 5)
        {
            PrintEven = "Fifth";
        }
        else if (SetPrintEVEN == 6)
        {
            PrintEven = "Sixth";
        }
        else if (SetPrintEVEN == 7)
        {
            PrintEven = "Seventh";
        }
        else if (SetPrintEVEN == 8)
        {
            PrintEven = "Eighth";
        }
        else if (SetPrintEVEN == 9)
        {
            PrintEven = "Ninth";
        }
        else if (SetPrintEVEN == 10)
        {
            PrintEven = "Tenth";
        }

        if (OddOrEven == "even")
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", PrintEven, OddOrEven, EvenCount);
        }
        else if (OddOrEven == "odd")
        {
            Console.WriteLine("{0} set has the most {1} numbers: {2}", PrintOdd, OddOrEven, OddCount);
        }
    }
}
