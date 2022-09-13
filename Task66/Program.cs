// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число: ");
Console.Write("M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N: ");
int n = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
        return;
    }
    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumber(m - 1, n);
    }
    else
    {
        NaturalNumber(m, n - 1);
        Console.Write($"{n} ");
    }
}

int summ = 0;

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

NaturalNumber(m, n);
PrintSumm(m, n, summ);