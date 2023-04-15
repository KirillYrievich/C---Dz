// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Input any numbers separated by a space: ");
string strNumbers = System.Console.ReadLine();
string inputString = strNumbers.ToString();
int [] ints = inputString.Split(' ').Select(Int32.Parse).ToArray();
int count = 0;

void Task1(int [] array)
{

    for (int i = 0; i < array.Length; i++)
    {   
        System.Console.Write($"{array[i]}; ");
        if (array[i] > 0)
        {
            count ++;
        }
    }
    System.Console.WriteLine($"-> {count}");
    return;
}

Task1(ints);