using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WeirdCombinations
{
    static void Main()
    {
        string GivenSTR = Console.ReadLine();
        int counter = 0;
        int Number = int.Parse(Console.ReadLine());
        int[] chars = GivenSTR.Select(x => Convert.ToInt32(x)).ToArray();        
        int index1 = 0;
        int index2 = 0;
        int index3 = 0;
        int index4 = 0;
        int index5 = 0;
        bool noPrint = true;
        while (true)
        {
            int a = chars[index1];
            while (true)
            {
                int b = chars[index2];
                while (true)
                {
                    int c = chars[index3];
                    while (true)
                    {
                        int d = chars[index4];
                        while (true)
                        {
                            int e = chars[index5];
                            if (counter == Number)
                            {
                                Console.WriteLine("{0}{1}{2}{3}{4}", (char)a, (char)b, (char)c,(char)d, (char)e);
                                noPrint = false;
                                return;
                                
                            }
                            counter += 1;
                            index5 += 1;
                            if (index5 == 5)
                            {
                                index5 = 0;
                                index4 += 1;
                                break;
                            }
                        }                        
                        if (index4 == 5)
                        {
                            index4 = 0;
                            index3 += 1;
                            break;
                            
                        }
                    }
                    
                    if (index3 == 5)
                    {
                        index3 = 0;
                        index2 += 1;
                        break;
                        
                    }
                }
                
                if (index2 == 5)
                {
                    index2 = 0;
                    index1 += 1;
                    break;
                    
                }
            }
            
            if (index1 == 5)
            {
                index1 = 0;
                break;
                
            }
                        
        }
        if (noPrint)
        {
            Console.WriteLine("No");
        }
        
    }
}