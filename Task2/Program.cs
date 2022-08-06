// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Console.WriteLine("Введите целое число1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число2");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 >= num2) {
    Console.WriteLine($"Большее число {number1}");
    Console.WriteLine($"Меньшее число {number2}");
} else if (num2 >= num1) {
   Console.WriteLine($"Большее число {number2}");
   Console.WriteLine($"Меньшее число {number1}"); 
};
    