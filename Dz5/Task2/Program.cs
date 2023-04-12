// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void Main()
{
    bool isWorking = true;

    while (isWorking)
    {
        System.Console.WriteLine("Input task number: ");
        string task = System.Console.ReadLine();

        switch (task)
        {
            case "t2": Task2(CreateArray()); break;
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
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}


void Task2(int [] array)
{
    int count = 0;
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {   
        count ++;
        if (count % 2 == 0) summ += array[i];
        System.Console.Write($"{array[i]}; ");
        
    }
    System.Console.WriteLine($"-> {summ}");
    return;
}

Main();