using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class HalfByteSwapper
{
    static void Main()
    {
        uint FirstNumber = uint.Parse(Console.ReadLine());
        string FirstNumberWholeBits = Convert.ToString(FirstNumber, 2).PadLeft(32, '0');
        string[] FirstNumberArray = new string[8];
        int First = 0;
        for (int i = 0; i < FirstNumberArray.Length; i++)
        {
            FirstNumberArray[i] = FirstNumberWholeBits.Substring(First, 4);
            First += 4;
        }
        Array.Reverse(FirstNumberArray);
        uint SecondNumber = uint.Parse(Console.ReadLine()); ;
        string SecondNumberWholeBits = Convert.ToString(SecondNumber, 2).PadLeft(32, '0');
        string[] SecondNumberArray = new string[8];
        int Second = 0;
        for (int i = 0; i < FirstNumberArray.Length; i++)
        {
            SecondNumberArray[i] = SecondNumberWholeBits.Substring(Second, 4);
            Second += 4;
        }
        Array.Reverse(SecondNumberArray);
        uint ThirdNumber = uint.Parse(Console.ReadLine()); ;
        string ThirdNumberWholeBits = Convert.ToString(ThirdNumber, 2).PadLeft(32, '0');
        string[] ThirdNumberArray = new string[8];
        int Third = 0;
        for (int i = 0; i < ThirdNumberArray.Length; i++)
        {
            ThirdNumberArray[i] = ThirdNumberWholeBits.Substring(Third, 4);
            Third += 4;
        }
        Array.Reverse(ThirdNumberArray);
        uint FourthNumber = uint.Parse(Console.ReadLine()); ;
        string FourthNumberWholeBits = Convert.ToString(FourthNumber, 2).PadLeft(32, '0');
        string[] FourthNumberArray = new string[8];
        int Fourth = 0;
        for (int i = 0; i < FourthNumberArray.Length; i++)
        {
            FourthNumberArray[i] = FourthNumberWholeBits.Substring(Fourth, 4);
            Fourth += 4;
        }
        Array.Reverse(FourthNumberArray);
        while (true)
        {
            string FirstCommandStr = Console.ReadLine();
            if (FirstCommandStr == "End")
            {
                break;
            }
            string SecondCommandStr = Console.ReadLine();
            int[] FirstCommand = FirstCommandStr.Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] SecondCommand = SecondCommandStr.Split(' ').Select(x => int.Parse(x)).ToArray();
            string FirstNeededSTR = "";
            string SecondNeededSTR = "";
            if (FirstCommand[0] == 0)
            {
                FirstNeededSTR = FirstNumberArray[FirstCommand[1]];
            }
            else if (FirstCommand[0] == 1)
            {
                FirstNeededSTR = SecondNumberArray[FirstCommand[1]];
            }
            else if (FirstCommand[0] == 2)
            {
                FirstNeededSTR = ThirdNumberArray[FirstCommand[1]];
            }
            else if (FirstCommand[0] == 3)
            {
                FirstNeededSTR = FourthNumberArray[FirstCommand[1]];
            }
            if (SecondCommand[0] == 0)
            {
                SecondNeededSTR = FirstNumberArray[SecondCommand[1]];
            }
            else if (SecondCommand[0] == 1)
            {
                SecondNeededSTR = SecondNumberArray[SecondCommand[1]];
            }
            else if (SecondCommand[0] == 2)
            {
                SecondNeededSTR = ThirdNumberArray[SecondCommand[1]];
            }
            else if (SecondCommand[0] == 3)
            {
                SecondNeededSTR = FourthNumberArray[SecondCommand[1]];
            }
            if (FirstCommand[0] == 0)
            {
                FirstNumberArray[FirstCommand[1]] = SecondNeededSTR;
            }
            else if (FirstCommand[0] == 1)
            {
                SecondNumberArray[FirstCommand[1]] = SecondNeededSTR;
            }
            else if (FirstCommand[0] == 2)
            {
                ThirdNumberArray[FirstCommand[1]] = SecondNeededSTR;
            }
            else if (FirstCommand[0] == 3)
            {
                FourthNumberArray[FirstCommand[1]] = SecondNeededSTR;
            }
            if (SecondCommand[0] == 0)
            {
                FirstNumberArray[SecondCommand[1]] = FirstNeededSTR;
            }
            else if (SecondCommand[0] == 1)
            {
                SecondNumberArray[SecondCommand[1]] = FirstNeededSTR;
            }
            else if (SecondCommand[0] == 2)
            {
                ThirdNumberArray[SecondCommand[1]] = FirstNeededSTR;
            }
            else if (SecondCommand[0] == 3)
            {
                FourthNumberArray[SecondCommand[1]] = FirstNeededSTR;
            }

        }
        Array.Reverse(FirstNumberArray);
        Array.Reverse(SecondNumberArray);
        Array.Reverse(ThirdNumberArray);
        Array.Reverse(FourthNumberArray);
        string FirstNewNumStr = string.Join("", FirstNumberArray);
        BigInteger FirstNewNum = Convert.ToInt64(FirstNewNumStr, 2);
        Console.WriteLine(FirstNewNum);
        string SecondNewNumStr = string.Join("", SecondNumberArray);
        BigInteger SecondNewNum = Convert.ToInt64(SecondNewNumStr, 2);
        Console.WriteLine(SecondNewNum);
        string ThirdNewNumStr = string.Join("", ThirdNumberArray);
        BigInteger ThirdNewNum = Convert.ToInt64(ThirdNewNumStr, 2);
        Console.WriteLine(ThirdNewNum);
        string FourthNewNumStr = string.Join("", FourthNumberArray);
        BigInteger FourthNewNum = Convert.ToInt64(FourthNewNumStr, 2);
        Console.WriteLine(FourthNewNum);
        
    }
}
