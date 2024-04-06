using System;

class Program 
{    
    static void Main()    
    {        
        Client vova = new Client();
        Client petya = new Client("Петя");
        Client dima = new Client("Дима", 10000);
        
        Console.WriteLine($"Имя: {vova.Name}, возраст: {vova.Age}");
        Console.WriteLine($"Имя: {petya.Name}, возраст: {petya.Age}");
        Console.WriteLine($"Имя: {dima.Name}, возраст: {dima.Age}");
        
        vova.Delete();
        petya.Delete();
        dima.Delete();
    }
}

class Client
{    
    private string name;    
    private int age;  
    
    public string Name    
    {        
        get { return name; }        
        set { name = value; }    
    }    

    public int Age    
    {        
        get { return age; }        
        set { age = value; }    
    }    

    public Client() : this("Не указанно")
    { }    

    public Client(string name) : this(name, 18)    
    { }    

    public Client(string name, int age)    
    {        
        this.name = name;        
        this.age = age;    
    }    

    public void Delete()
    {
        Console.WriteLine($"{name} has deleted");
    }

    ~Client()    
    {        
        Console.WriteLine($"{name} has deleted");    
    }    
}