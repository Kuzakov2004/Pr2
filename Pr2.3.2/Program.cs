using System;
class Program{
    static void Main()    
    {
        Worker dima = new Worker();        
        Console.WriteLine($"Имя: {dima.GetName()} \nФамилия: {dima.GetSurname()} \nСтавка: {dima.GetRate()} \nОтработанные дни: {dima.GetDays()}");
        dima.GetSalary();    
    }
}
class Worker
{
    private string name = "Dima";    
    private string surname = "Kuzakov";
    private double rate = 2.8;    
    private int days = 10;
    public string GetName()
    {        
        return name;
    }
    public string GetSurname()    
    {
        return surname;    
    }
    public double GetRate()
    {        
        return rate;
    }
    public int GetDays()    
    {
        return days;    
    }

    public void GetSalary()
    {        
        Console.WriteLine($"Зарплата: {days * rate}");
    }
    
}