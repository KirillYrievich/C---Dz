// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Main();

void Main()
{
    bool isWorking = true;

    while(isWorking)
    {
        System.Console.WriteLine("Input task number: ");
        string task = Console.ReadLine();

        switch(task)
        {
            case "t1": Task1(); break;
            case "t2": Task2(); break;
            case "t3": Task3(); break;
            case "exit": 
                System.Console.WriteLine("Bye (^-^)/");
                isWorking = false; break;
            default: System.Console.WriteLine("Такого задания нет, введите корректное значение задания!");
                break;
        }
    }
}


void Task1()
{
  int numder = ReadInt("three-digit number");
  int count = 0;
  string strNumber = numder.ToString();
  char[] dig_mas = strNumber.ToCharArray();
    foreach (char i in dig_mas)
        if (count == 1)
        {
            Console.WriteLine(i);
            break;
        }
        else count ++;
}


void Task2()
{
  int numder = ReadInt("any number");
  int count = 0;
  string strNumber = numder.ToString();
  char[] dig_mas = strNumber.ToCharArray();
    foreach (char i in dig_mas)

        if (count == 2)
        {
            Console.WriteLine(i);
            count ++;
            break;
        }
        else count ++;
        if (count < 2) System.Console.WriteLine("Второй и третьей цифры нет");
        else if (count == 2) System.Console.WriteLine("Третьей цифры нет");
}


void Task3()
{
  int numder = ReadInt("number 1 to 7");
  if (numder == 6 || numder == 7) System.Console.WriteLine("Да");
  else System.Console.WriteLine("Нет");

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