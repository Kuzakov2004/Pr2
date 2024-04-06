using System; 
using System.Collections.Generic; 
 
class Program 
{
    static void Main()
    {
        Train lastochka = new Train();
        Train vostok = new Train();
        Train zapad = new Train();

        lastochka.TrainNumber = 624;
        lastochka.NameOfDestination = "Бийск";
        lastochka.DepartureTime = new TimeOnly(18, 30, 00);

        vostok.TrainNumber = 931;
        vostok.NameOfDestination = "Адлер";
        vostok.DepartureTime = new TimeOnly(9, 00, 00);

        zapad.TrainNumber = 567;
        zapad.NameOfDestination = "Москва";
        zapad.DepartureTime = new TimeOnly(15, 20, 00);
        
        
        Console.WriteLine("Введите номер поезда (624, 931, 567) ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case 624:
                lastochka.PrintTrain();
                break;
            case 931:
                vostok.PrintTrain();
                break;
            case 567:
                zapad.PrintTrain();
                break;
            default:
                Console.WriteLine("Неверно набран номер поезда");
                break;
        }
    }
}

class Train
{
    public string NameOfDestination;
    public TimeOnly DepartureTime = new TimeOnly();
    public int TrainNumber;

    public void PrintTrain()
    {
        Console.WriteLine($"название пункта назначения: {NameOfDestination} \nномер поезда: {TrainNumber} \nвремя отправления: {DepartureTime} \n");
    }
}