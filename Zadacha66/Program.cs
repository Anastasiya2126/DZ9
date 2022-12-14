/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */



int number1 = ReadInt("Введите число M: ");
int number2 = ReadInt("Введите число N: ");


Console.WriteLine(SumElements(number1, number2));



int SumElements(int m, int n)
{
    if (n > m)
        return n + SumElements(m, n - 1);
    else if (m > n)
        return m + SumElements(n, m - 1);
    else
        return m;
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
