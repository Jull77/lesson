// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int DeleteMiddleDigit(int number)
{
    int firstDigit = number / 10;
    int res = firstDigit % 10;
    return res;
}

int res = DeleteMiddleDigit(number);

Console.WriteLine($"Вторая цифра этого числа -> {res}");

