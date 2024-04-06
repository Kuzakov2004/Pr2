using System; 
using System.Collections.Generic; 
 
class Program 
{
    static void Main()
    {
        Counter example1 = new Counter();
        Counter example2 = new Counter();

        example2.Count = 10;

        for (int i = 0; i < 5; i++)
        {
            example1.increase();
            example2.decrease();
        }
        
        Console.WriteLine(example1.Count);
        Console.WriteLine(example2.Count);
    }
}

class Counter
{
    private int count = 0;

    public int Count
    {
        get { return count; }
        set { count = value; }
    }

    public void increase()
    {
        Count++;
    }
    
    public void decrease()
    {
        Count--;
    }
}
