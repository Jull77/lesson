// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая 
// покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr1 = CreateArrayRndInt(4, 100, 1000);
PrintArray(arr1); 
Console.WriteLine(" -> " + CalcArr(arr1));

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Случайные положительные трёхзначные числа: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]. Количество чётных чисел в массиве");
}

int CalcArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] %2 == 0)
        {
            count++;
        }
    }
    return count;
}

