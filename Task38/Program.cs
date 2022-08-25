// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr1 = CreateArrayRndDouble (5, 0, 1);
// PrintArray(arr1); 
// Console.WriteLine(" -> " + CalcArr(arr1));

int max = 0;
int min = 0;
int num = max -  min;
// int num = 0;

double[] CreateArrayRndDouble (int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * ((max-min) + max)), 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}

int CalcArr(int[] arr)
{
    int max = 0;
    int min = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]  >= max)
        {
            max = arr[i];
        }
        else if (arr[i] <= min)
        {
            min = arr[i];
        }
       count++;
    }
    return max; 
    return min;
}


