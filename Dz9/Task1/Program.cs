// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = InputInt("Введите положительное число: ");
int count = 1;
if (number < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(NaturalNumber(number, count));

int NaturalNumber(int number, int count)
{
    if (number == count)
        return number;
    else
        Console.Write($"{NaturalNumber(number, count + 1)}, ");
    return count;
}

int InputInt(string number)
{
    Console.Write(number);
    return int.Parse(Console.ReadLine());
}