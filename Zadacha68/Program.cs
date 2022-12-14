﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int numberM = ReadInt("Введите число m: ");
int numberN = ReadInt("Введите число n: ");


if (numberM < 0 || numberN <0)
{
    Console.WriteLine("Вы ввели некорректное число");
}


Console.Write($"m = {numberM}, n = {numberN} -> A(m,n) = ");
Console.WriteLine(Akkerman(numberM, numberN));


int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
    {
        if (n == 0)
            return Akkerman(m - 1, 1);
        else
            return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}