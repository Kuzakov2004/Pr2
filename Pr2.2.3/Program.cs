using System; 
using System.Collections.Generic; 
 
class Program 
{
    static void Main()
    {
        Numbers example = new Numbers();
        example.ChangeNumbers();
        example.PrintNumbers();
        int sum = example.SumNumbers();
        int max = example.MaxNumbers();
        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"max: {max}");
    }
}

class Numbers
{
    private int number1;
    private int number2;

    public int Number1
    {
        get { return number1; }
        set { number1 = value; }
    }

    public int Number2
    {
        get { return number2; }
        set { number2 = value; }
    }

    public void PrintNumbers()
    {
        Console.WriteLine($"Первое число: {Number1} \nВторое число: {Number2}");
    }

    public void ChangeNumbers()
    {
        Console.WriteLine("Введите 1 число ");
        Number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите 2 число ");
        Number2 = int.Parse(Console.ReadLine());
    }

    public int SumNumbers()
    {
        return number1 + number2;
    }

    public int MaxNumbers()
    {
        if (number1 > number2)
        {
            return number1;
        }
        return number2;
        
    }
}