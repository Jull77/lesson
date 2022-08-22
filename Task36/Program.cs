// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr1 = CreateArrayRndInt(4, -100, 100);
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
    Console.Write("Случайные числа: [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]. Сумма элементов, стоящих на нечётных позициях");
}

int CalcArr(int[] arr)
{
    int sum = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i %2 != 0)
        {
            sum = sum + arr[i];
            count++;
        }
    }
    return sum;
}

