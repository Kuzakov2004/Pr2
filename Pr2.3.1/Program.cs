using System; 
using System.Collections.Generic;  
class Program 
{    
    static void Main()    
    {        
        Worker dima = new Worker();
        dima.Name = "Dima";
        dima.Surname = "Kuzakov";
        dima.Rate = 300.50;
        dima.Days = 10;
        dima.GetSalary();
    }
    
}
class Worker
{    
    public string Name;
    public string Surname;
    public double Rate;
    public int Days;
    
    public void GetSalary()
    {
        Console.WriteLine(Days * Rate);    
    }
}