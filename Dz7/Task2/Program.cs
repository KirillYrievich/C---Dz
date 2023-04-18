// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

System.Console.WriteLine("Введите количество строк");
int line = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[column, line];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,1000));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
        
}

Console.WriteLine(); 
Console.WriteLine("Введите  номер строки: ");
int numLine = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int numColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (numColumn>column && numLine>line) Console.WriteLine("такого числа нет");
else
 {
 object result = array.GetValue(numLine-1,numColumn-1);
 Console.WriteLine(result);
 }
