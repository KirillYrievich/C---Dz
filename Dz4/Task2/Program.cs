// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Main();

void Main()
{
    bool isWorking = true;
    
    while (isWorking)
    {
        System.Console.WriteLine("Input task number: ");
        string task = Console.ReadLine();

            switch (task)
        {
            case "t1": Task1(); break;
            case "t2": Task2(); break;
            case "exit": 
                System.Console.WriteLine("See you later (^_^)/");
                isWorking = false; break; 
            default: 
                System.Console.WriteLine("Такого задания нет, введите корректное значение задания!");
                break;
        }
    }
}

void Task1()
{
 int numberA = ReadInt("number A");
 int numberB = ReadInt("number B");
 int count = numberA; 
 
 for (int i = 0; i < (numberB - 1); i++)
 {
    count = count * numberA;
 }

 System.Console.WriteLine($"-> {count}");
}

void Task2()
{
    int number = ReadInt("any number");
    int count = 0;

    while (number > 0)
    {
       count += number % 10;
       number /= 10;
    }
    System.Console.WriteLine(count);
}   


int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");

    while (! int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("It's not a number!");
    }

    return number;
}