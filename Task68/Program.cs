// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3 n = 2 -> A(m,n) = 29


Console.WriteLine("Введите целое положительное число: ");
Console.Write("m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");