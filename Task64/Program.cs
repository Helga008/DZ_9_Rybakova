// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int GetUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}


void ListNumbers(int number)
{
    if (number <= 0)
    {
        return;
    }
    ListNumbers(number - 1);
    Console.Write(number + ",");
    
}


int a = GetUserData("Введите число: ");
ListNumbers(a);


