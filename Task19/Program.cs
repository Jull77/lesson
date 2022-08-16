// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num % 10; 
int num2 = num / 10000; 
int num3 = num % 100 / 10; 
int num4 = num / 1000 % 10; 


if (num1 == num2 && num3 == num4)
{
    Console.WriteLine("Число палиндром");
}
else
{
    Console.WriteLine("Число не является палиндромом");
};