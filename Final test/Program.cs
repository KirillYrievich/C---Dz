
// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string [] originalnArray = {"Hello", "World", "123456789", "^_^", "C#", };
string [] resultArray = new string[CountElArray(originalnArray)];
int count = 0;

for (int i = 0; i < originalnArray.Length; i++)
{
    if (originalnArray[i].Length <= 3) 
    {
        resultArray[count] = originalnArray[i];
        count ++;
    }
}


PrintArray(resultArray);


void PrintArray(string [] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine(array[array.Length - 1] + "]");
}


int CountElArray(string [] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
            if (array[i].Length <= 3) count ++;
    }
    return count;
}