// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void Main()
{
    bool isWorking = true;

    while (isWorking)
    {
        System.Console.WriteLine("Input task number: ");
        string task = System.Console.ReadLine();

        switch (task)
        {
            case "t1": Task1(CreateArray()); break;
            case "exit": 
                System.Console.WriteLine("See you later (^_^)/");
                isWorking = false; break; 
            default: 
                System.Console.WriteLine("Такого задания нет, введите корректное значение задания!");
                break;
        }
    }
}


int ReadInt(string argument)
{
    int number;
    System.Console.WriteLine($"Input {argument}");

    while (! int.TryParse(System.Console.ReadLine(), out number))
    {
        System.Console.WriteLine("It's not a number");
    }
    return number;
}


int [] CreateArray()
{
    int Length = ReadInt("arr len:");
    int [] arr = new int [Length];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}


void Task1(int [] array)
{
    int count = 0;
    System.Console.Write("[");

    for (int i = 0; i < array.Length - 1; i++)
    {   
        System.Console.Write($"{array[i]}; ");
        if (array[i] % 2 == 0) count ++;
    }
    System.Console.WriteLine($"{array[array.Length - 1]}] -> {count}");
    return;
}

Main();