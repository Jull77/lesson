// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if(number / 10000 != 0 &number / 100000 ==0) 
{
   int res = number / 100 % 10;
   Console.WriteLine($"Третья цифра этого числа -> {res}");
} 
if (number / 1000 != 0 & number / 10000 ==0)
{
   int res = number / 10 % 10;
   Console.WriteLine($"Третья цифра этого числа -> {res}");
} 
if (number / 100 != 0 & number / 1000 ==0)
{
   int res = number % 10;
   Console.WriteLine($"Третья цифра этого числа -> {res}");
} 
if (number / 100 == 0)
{
   Console.WriteLine("Третьей цифры нет"); 
};

