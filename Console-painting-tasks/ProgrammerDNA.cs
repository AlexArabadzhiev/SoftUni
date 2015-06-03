using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        char dot = '.';
        int Row = 2;
        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", dot, dot, dot, letter, dot, dot, dot);
        for (int i = 1; i < n; i++)
        {
            switch (Row)
            {
                case 1: letter = next(letter);
                    Row = 2;
                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", dot, dot, dot, letter, dot, dot, dot); break;
                case 2: Row = 3;
                    Console.Write(dot);
                    Console.Write(dot);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(dot);
                    Console.Write(dot);
                    Console.WriteLine(); break;
                case 3: Row = 4;
                    Console.Write(dot);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(dot);
                    Console.WriteLine(); break;
                case 4: Row = 5;
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.WriteLine(); break;                    
                case 5: Row = 6;
                    Console.Write(dot);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(dot);
                    Console.WriteLine(); break;
                case 6: Row = 7;
                    Console.Write(dot);
                    Console.Write(dot);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(next(letter)); letter = next(letter);
                    Console.Write(dot);
                    Console.Write(dot);
                    Console.WriteLine(); break;
                case 7: letter = next(letter);
                    Row = 1;
                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", dot, dot, dot, letter, dot, dot, dot); break;

                default: break;
            }
        }
    }
    static char next (char letter)
    {
        letter++;
        if (letter > 'G')
        {
            letter = 'A';
        }
        return letter;
    }
    
}