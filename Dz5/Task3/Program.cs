// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arr = new double[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Math.Round((new Random().NextDouble() * arr.Length), 2);
}

double maxNumber = 0;
double minNumber = 10;
for (int i = 0; i < arr.Length; i++)
{
    System.Console.Write($"{arr[i]}; ");
    if (arr[i] > maxNumber) maxNumber = arr[i]; 
    else if (arr[i] < minNumber) minNumber = arr[i]; 
    
}
System.Console.WriteLine();
System.Console.WriteLine($"Max number: {maxNumber}");
System.Console.WriteLine($"Min number: {minNumber}");
System.Console.WriteLine("Разница составляет: " + Math.Round((maxNumber - minNumber), 2));

// Сложно с вещественными массивами. 
// Как правильно преобразовывать int в double что бы использовать ф-ции так и не стало мне понятно.