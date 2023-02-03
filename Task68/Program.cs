// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int GetUserData(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int Akkerman(int m, int n)
{
     
    if (m==0) 
    {
        return n+1;
    }    
    else if (n==0 && m > 0) 
    {
        return Akkerman(m-1,1);
    }    
    else
    {
        return (Akkerman(m-1,Akkerman(m, n - 1)));
    }
    
}


int a = GetUserData("Введите первое число: ");
int b = GetUserData("Введите второе число: ");
int akk = Akkerman(a, b);
Console.Write(akk);