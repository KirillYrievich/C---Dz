// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int [] arr = new int [8];
int len = arr.Length;


void CreateArr(int lengthArr)
{
    for (int i = 0; i < lengthArr; i++)
    {
        arr[i] = new Random().Next(0, 100);
        
    }
    System.Console.WriteLine(String.Join(", ", arr));
}

CreateArr(len);