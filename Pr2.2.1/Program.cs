using System; 
using System.Collections.Generic; 
 
class Program 
{
    static void Main()
    {
        Student dima = new Student();
        dima.AcademicPerformance = new int[5] { 2, 3, 4, 5, 5 };
        dima.groupNumber = 624;
        Console.WriteLine("Ведите номер группы");
        dima.groupNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите фамилию");
        dima.Surname = Console.ReadLine();
        Console.WriteLine("Введите дату рождения в формате ГГГГ-ММ-ДД");
        dima.DateOfBirth = DateOnly.Parse(Console.ReadLine());
        dima.PrintStudent();
    }
}

class Student
{
    public string Surname;
    public DateOnly DateOfBirth = new DateOnly();
    public int groupNumber;
    public int[] AcademicPerformance;

    public void PrintStudent()
    {
        Console.WriteLine($"Фамилия: {Surname} \n Дата рождения: {DateOfBirth} \n Номер группы: {groupNumber} \n");
        Console.WriteLine("Оценки");
        foreach (int x in AcademicPerformance)
        {
            Console.Write($"{x} ");
        }
    }
}