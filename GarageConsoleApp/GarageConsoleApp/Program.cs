using System.Diagnostics;

namespace GarageConsoleApp;

/// <summary>
/// Класс Program
/// здесь описываем логику приложения
/// вызываем нужные методы пишем обработчики и тд
/// </summary>
public class Program 
{
    public static void Main(string[] args)
    {
        bool flag = true;
        int inputUserNum = 0;
        int inputUserNum2 = 0;
        string inputUserStr = "";
        string nameDriver = "";
        string lastNameDriver = "";
        int idType = 0;
        int inputuserNums3 = 0;
        DateTime dateDriver = new DateTime();

        while (flag)
        {
            Console.WriteLine("Введите номер команды \n1 - просмотр типов машин \n2 - добавления нового типа машины \n3 - просмотр водителей \n4 - добавление нового водителя \n5 -  добавление категории прав \n6 - Добавление категории прав водителю \n7 - Вывод категории прав водителя \n8 - добавление новой машины \n9 - просмотр всех машин \n10 -  добавление маршрута \n11 - просмотр всех маршрутов \n12 - добавление нового рейса \n13 - просмотр рейсов \n0 - завершить программу");
            try
            {
                inputUserNum = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка! Неверый формат ввода");
            }

            switch (inputUserNum)
            {
                case 1:
                    DatabaseRequests.GetTypeCarQuery();
                    break;
                case 2:
                    Console.WriteLine("Введите новый тип машины");
                    inputUserStr = Console.ReadLine();
                    if (inputUserStr == null)
                    {
                        Console.WriteLine("Ошибка ввода");
                        break;
                    }
                    DatabaseRequests.AddTypeCarQuery(inputUserStr);
                    Console.WriteLine("Ввод был произведён коректно");
                    break;
                case 3:
                    DatabaseRequests.GetDriverQuery();
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Введите имя водителя");
                    nameDriver = Console.ReadLine();
                    if (nameDriver == null)
                    {
                        Console.WriteLine("Ошибка ввода");
                        break;
                    }
                    Console.WriteLine("Введите фамилию водителя");
                    lastNameDriver = Console.ReadLine();
                    if (lastNameDriver == null)
                    {
                        Console.WriteLine("Ошибка ввода");
                        break;
                    }
                    Console.WriteLine("Введите дату рождения водителя в формате ГГГГ-ММ-ДД");
                    try
                    {
                        dateDriver = DateTime.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    
                    DatabaseRequests.AddDriverQuery(nameDriver, lastNameDriver, dateDriver);
                    Console.WriteLine("Ввод был произведён коректно");
                    break;
                case 5:
                    Console.WriteLine("Введите категорию прав");
                    inputUserStr = Console.ReadLine();
                    if (inputUserStr != null || inputUserStr.Length  <= 3)
                    {
                        DatabaseRequests.AddRightsCategoryQuery(inputUserStr);
                        Console.WriteLine("Ввод был произведён коректно");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    break;
                case 6:
                    Console.WriteLine("Введите ID водителя и ID категории прав");
                    
                    try
                    {
                        inputUserNum = int.Parse(Console.ReadLine());
                        inputUserNum2 = int.Parse(Console.ReadLine());
                        DatabaseRequests.AddDriverRightsCategoryQuery(inputUserNum, inputUserNum2);
                        Console.WriteLine("Ввод был произведн коректно");
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    
                    break;
                case 7:
                    Console.WriteLine("Введите ID водителя");
                    try
                    {
                        inputUserNum = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    DatabaseRequests.GetDriverRightsCategoryQuery(inputUserNum);
                    Console.WriteLine("Ввод был произведн коректно");
                    break;
                case 8:
                    Console.WriteLine("Введите id типа машины, название, номер и количество пассажиров");
                    try
                    {
                        idType = int.Parse(Console.ReadLine());
                        inputUserStr = Console.ReadLine();
                        nameDriver = Console.ReadLine();
                        inputUserNum2 = int.Parse(Console.ReadLine());
                        DatabaseRequests.AddCarsQuery(idType, inputUserStr, nameDriver, inputUserNum2);
                    }
                    catch 
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    break;
                case 9:
                    DatabaseRequests.GetCarQuery();
                    Console.WriteLine();
                    break;
                case 10:
                    Console.WriteLine("ведите маршрут в формате город-город");
                    inputUserStr = Console.ReadLine();
                    if (inputUserStr != null)
                    {
                        DatabaseRequests.AddItineraryQuery(inputUserStr);
                        Console.WriteLine("Ввод был произведён коректно");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода");
                    }
                    break;
                case 11:
                    DatabaseRequests.GetItineraryQuery();
                    Console.WriteLine();
                    break;
                case 12:
                    Console.WriteLine("Введите id водителя, id машины, id маршрута и кол во пассажиров");
                    try
                    {
                        inputUserNum = int.Parse(Console.ReadLine());
                        inputUserNum2 = int.Parse(Console.ReadLine());
                        inputuserNums3 = int.Parse(Console.ReadLine());
                        idType = int.Parse(Console.ReadLine());
                        DatabaseRequests.AddRouteQuery(inputUserNum, inputUserNum2, inputuserNums3, idType);
                        Console.WriteLine("Ввод был произведён коректно");
                    }
                    catch
                    {
                        Console.WriteLine("ошибка ввода");
                    }
                    break;
                case 13:
                    DatabaseRequests.GetRoutQuery();
                    Console.WriteLine();
                    break;
                case 0:
                    Console.WriteLine("Программа завершена");
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Ошибка ввода");
                    break;
            }
        }
    }
}

/* Вызовем метод для получения данных о водителях
         DatabaseRequests.GetDriverQuery();
         Console.WriteLine();
         // Добавим нового водителя в БД
         DatabaseRequests.AddDriverQuery("Денис", "Иванов", DateTime.Parse("1997.01.12"));
         // Вызовем метод для получения данных о водителях
         DatabaseRequests.GetDriverQuery();
         
         // Вызовем метод для получения данных о типах автомобилей
         DatabaseRequests.GetTypeCarQuery();
         Console.WriteLine();
         // Добавим новый тип автомобиля в БД
         DatabaseRequests.AddTypeCarQuery("Воздушный");
         // Вызовем метод для получения данных о типах автомобилей
         DatabaseRequests.GetTypeCarQuery();*/
         