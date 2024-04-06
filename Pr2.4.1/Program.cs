using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int result = RomanToInt(input[input.Length - 1]);

        for (int i = input.Length - 2; i >= 0; i--)
        {
            if (RomanToInt(input[i]) < RomanToInt(input[i + 1]))
            {
                result -= RomanToInt(input[i]);
            }
            else
            {
                result += RomanToInt(input[i]);
            }
        }

        Console.WriteLine(result);
    }

    static int RomanToInt(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}