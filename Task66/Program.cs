// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int SumNumberInRange(int num1, int num2)
{
    if (num1 == num2)
    return num2;
    else if (num1 < num2) 
    return num2 + SumNumberInRange(num1, num2 - 1);
    else 
    return num2 + SumNumberInRange(num1, num2 + 1);
}


int a = GetUserData("Введите первое число: ");
int b = GetUserData("Введите второе число: ");
int sum = SumNumberInRange(a,b);
Console.Write(sum);

