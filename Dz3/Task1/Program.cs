// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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
            case "t3": Task3(); break;
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
    int number = ReadInt("a five-digit number");
    int firstNumber = number / 10000;
    int secondNumber = (number / 1000) % 10;
    int lastNumber = number % 10;
    int penultimateNumber = (number % 100) / 10;

    if (firstNumber == lastNumber && secondNumber == penultimateNumber) System.Console.WriteLine("Да!");
    else System.Console.WriteLine("Нет");
}


void Task2()
{
    int x1 = ReadInt("coordinates x1: ");
    int y1 = ReadInt("coordinates y2: ");
    int z1 = ReadInt("coordinates z3: ");

    int x2 = ReadInt("coordinates x1: ");
    int y2 = ReadInt("coordinates y2: ");
    int z2 = ReadInt("coordinates z3: ");

    double distance = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2);
    double distanseResult = distance;
    System.Console.WriteLine($"Distance -> {distanseResult}");
}


void Task3()
{
    int number = ReadInt("any number");

    for (int i = 1; i <= number; i++)
    {
        System.Console.WriteLine(Math.Pow(i, 3));
    }
   
}


int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}: ");

    while (! int.TryParse(Console.ReadLine(), out number))
    {
        System.Console.WriteLine("It's not a number");
    }

    return number;
}